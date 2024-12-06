using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wguSchedulingSoftware.DataModels;

namespace wguSchedulingSoftware
{
	public class DataProcedures
	{
		private const string server = "127.0.0.1";
		private const string database = "client_schedule";
		private const string uid = "user1";
		private const string password = "root";
		private const string connectionString = "server=" + server + ";" + "database=" + database + ";" + "uid=" + uid + ";" + "pwd=" + password + ";";


		// Verify if a user exists 
		public int verifyUser(User userinfo)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			int userId = -1;

			string returnedUserName;
			string returnedPassword;

			try
			{
				conn.Open();
				MySqlCommand checkUserNameCmd = conn.CreateCommand();
				checkUserNameCmd.CommandText = "SELECT EXISTS(SELECT userName FROM user WHERE userName = @username)";
				checkUserNameCmd.Parameters.AddWithValue("@username", userinfo.username);
				returnedUserName = checkUserNameCmd.ExecuteScalar().ToString();

				MySqlCommand checkPasswordCmd = conn.CreateCommand();
				checkPasswordCmd.CommandText = "SELECT EXISTS(SELECT password FROM user WHERE BINARY password = @password AND userName = @username)";
				checkPasswordCmd.Parameters.AddWithValue("@password", userinfo.password);
				checkPasswordCmd.Parameters.AddWithValue("@username", userinfo.username);
				returnedPassword = checkPasswordCmd.ExecuteScalar().ToString();

				if (returnedUserName == "1" && returnedPassword == "1")
				{
					MySqlCommand returnUserIdCmd = conn.CreateCommand();
					returnUserIdCmd.CommandText = "SELECT userId FROM user WHERE BINARY password = @password AND username = @username";
					returnUserIdCmd.Parameters.AddWithValue("@password", userinfo.password);
					returnUserIdCmd.Parameters.AddWithValue("@username", userinfo.username);
					userId = (int)returnUserIdCmd.ExecuteScalar();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception thrown when verifying user: " + ex);
			}
			finally
			{
				conn.Close();
			}

			return userId;

		}


		public bool registerUser(User userInfo)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			try
			{
				conn.Open();
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "INSERT INTO user(userName, password, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@username, @password, @active, CURRENT_TIMESTAMP, @createdBy, CURRENT_TIMESTAMP, 'system') ";
				cmd.Parameters.AddWithValue("@username", userInfo.username);
				cmd.Parameters.AddWithValue("@password", userInfo.password);
				cmd.Parameters.AddWithValue("@active", 1);
				cmd.Parameters.AddWithValue("@createdBy", userInfo.username);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exceptoin thrown when registering user: " + ex);
				return false;
			}

			return true;
		}

	}
}
