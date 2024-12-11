using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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


		public int addCountry(Country country)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			int countryId = -1;

			try
			{
				conn.Open();
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "INSERT INTO country(country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@country, CURRENT_TIMESTAMP, @createdBy, CURRENT_TIMESTAMP, 'system');" + "SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
				cmd.Parameters.AddWithValue("@country", country.country);
				cmd.Parameters.AddWithValue("@createdBy", country.createdBy);
				countryId = (int)cmd.ExecuteScalar();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception thrown when adding country: " + ex);
				countryId = -1;
			}
			finally
			{
				conn.Close();
			}

			return countryId;
				
		}



		public int addCity(City city)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			int cityId = -1;

			try
			{
				conn.Open();
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "INSERT INTO city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@city, @countryId, CURRENT_TIMESTAMP, @createdBy, CURRENT_TIMESTAMP, 'system');" + "SELECT cityId FROM city ORDER BY cityId DESC LIMIT 1";
				cmd.Parameters.AddWithValue("@city", city.city);
				cmd.Parameters.AddWithValue("@countryId", city.countryId);
				cmd.Parameters.AddWithValue("@createdBy", city.createdBy);
				cityId = (int)cmd.ExecuteScalar();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exeption thrown when adding city: " + ex);
				cityId = -1;
			}
			finally { conn.Close(); }

			return cityId;
		}



		public int addAddress(Address address)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			int addressId = -1;

			try
			{
				conn.Open();
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@address, 'na', @cityId, @postalCode, @phone, CURRENT_TIMESTAMP, @createdBy, CURRENT_TIMESTAMP, 'system');" + "SELECT addressId FROM address ORDER BY addressId DESC LIMIT 1";
				cmd.Parameters.AddWithValue("@address", address.address);
				cmd.Parameters.AddWithValue("@cityId", address.cityId);
				cmd.Parameters.AddWithValue("@postalCode", address.postalCode);
				cmd.Parameters.AddWithValue("@phone", address.phone);
				cmd.Parameters.AddWithValue("@createdBy", address.createdBy);

				addressId = (int)cmd.ExecuteScalar();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				addressId = -1;
			}
			finally { conn.Close(); }

			return addressId;

		}


		public bool addCustomer(Customer customer)
		{
			MySqlConnection con = new MySqlConnection(connectionString);

			try
			{
				con.Open();
				MySqlCommand cmd = con.CreateCommand();
				cmd.CommandText = "INSERT INTO customer(customerName, addressId, active,createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customerName,@addressId, @active, CURRENT_TIMESTAMP, @createdBy, CURRENT_TIMESTAMP, 'system')";
				cmd.Parameters.AddWithValue("@customerName", customer.customerName);
				cmd.Parameters.AddWithValue("@addressId", customer.addressId);
				cmd.Parameters.AddWithValue("@active", 1);
				cmd.Parameters.AddWithValue("@createdBy", customer.createdBy);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return false;
			}
			finally
			{
				con.Close();
			}

			return true;

		}


		public CustomerInformation getCustomerInformation(int customerId)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			CustomerInformation custInfo = new CustomerInformation();

			try
			{
				conn.Open();
				string query = "SELECT customer.customerName, address.phone, address.address, address.address2, address.postalCode, city.city, country.country FROM customer " +
					"LEFT JOIN address ON customer.addressId = address.addressId " +
					"LEFT JOIN city ON address.cityId = city.cityId " +
					"LEFT JOIN country ON city.countryId = country.countryId " +
					"WHERE customer.customerId = @custId";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@custId", customerId);
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						custInfo.customerName = reader["customerName"].ToString();
						custInfo.address = reader["address"].ToString();
						custInfo.city = reader["city"].ToString();
						custInfo.postalCode = reader["postalCode"].ToString();
						custInfo.country = reader["country"].ToString();
						custInfo.phone = reader["phone"].ToString();
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally { conn.Close(); }

			return custInfo;
			
		}


		public bool saveCustomerInformation(CustomerInformation custInfo)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			bool success = false;

			try
			{
				conn.Open();
				string updateCommand = "UPDATE customer SET customerName = @customerName WHERE customerId = @customerId; " +
					"UPDATE address SET address = @address, address2 = @address2, postalCode = @postalCode, phone = @phone " +
					"WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId); " +
					"UPDATE city SET city = @city " +
					"WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)); " +
					"UPDATE country SET country = @country " +
					"WHERE countryId = (SELECT countryId FROM city WHERE cityId = (SELECT cityId FROM address WHERE addressId = (SELECT addressId FROM customer WHERE customerId = @customerId)))";
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = updateCommand;
				cmd.Parameters.AddWithValue("@customerId", custInfo.customerID);
				cmd.Parameters.AddWithValue("@customerName", custInfo.customerName);
				cmd.Parameters.AddWithValue("@address", custInfo.address);
				cmd.Parameters.AddWithValue("@address2", "na");
				cmd.Parameters.AddWithValue("@city", custInfo.city);
				cmd.Parameters.AddWithValue("@postalCode", custInfo.postalCode);
				cmd.Parameters.AddWithValue("@country", custInfo.country);
				cmd.Parameters.AddWithValue("@phone", custInfo.phone);
				cmd.ExecuteNonQuery();

				success = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				success = false;
			}
			finally { conn.Close(); }

			return success;

		}


		public bool deleteCustomer(int customerID)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			try
			{
				conn.Open();
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "DELETE FROM customer WHERE customerId = @customerId";
				cmd.Parameters.AddWithValue("@customerId", customerID);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return false;
			}
			finally
			{
				conn.Close();
			}

			return true;
		}


		public int addAppointment(Appointment appt)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			int apptId = -1;

			try
			{
				conn.Open();
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy ) VALUES(@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, CURRENT_TIMESTAMP, 'user', CURRENT_TIMESTAMP, 'system');" +
					"SELECT appointmentId FROM appointment ORDER BY appointmentId DESC LIMIT 1";
				cmd.Parameters.AddWithValue("@customerId", appt.customerId);
				cmd.Parameters.AddWithValue("@userId", appt.userId);
				cmd.Parameters.AddWithValue("@title", appt.title);
				cmd.Parameters.AddWithValue("@description", appt.description);
				cmd.Parameters.AddWithValue("@location", appt.location);
				cmd.Parameters.AddWithValue("@contact", appt.contact);
				cmd.Parameters.AddWithValue("@type", appt.type);
				cmd.Parameters.AddWithValue("@url", appt.url);
				cmd.Parameters.AddWithValue("@start", appt.start);
				cmd.Parameters.AddWithValue("@end", appt.end);
				apptId = (int)cmd.ExecuteScalar();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			finally
			{
				conn.Close();
			}

			return apptId;
		}

		public Appointment getAppointmentInformation(int apptId)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			Appointment apptInfo = new Appointment();

			try
			{
				conn.Open();
				string query = "SELECT customerId, userId, title, description, location, contact, type, url, start, end FROM appointment WHERE appointmentId = @appointmentId";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@appointmentId", apptId);
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						apptInfo.customerId = (int)reader["customerId"];
						apptInfo.userId = (int)reader["userId"];
						apptInfo.title = reader["title"].ToString();
						apptInfo.description = reader["description"].ToString();
						apptInfo.location = reader["location"].ToString();
						apptInfo.contact = reader["contact"].ToString();
						apptInfo.type = reader["type"].ToString();
						apptInfo.url = reader["url"].ToString();
						apptInfo.start = Convert.ToDateTime(reader["start"]);
						apptInfo.end = Convert.ToDateTime(reader["end"]);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			finally
			{
				conn.Close();
			}

			return apptInfo;
		}



		public bool updateAppointment(Appointment apptInfo)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			bool success = false;

			try
			{
				conn.Open();
				string updateCommand = "UPDATE appointment SET customerId = @customerId, userId = @userId, title = @title, description = @description, location = @location, " +
					"contact = @contact, url = @url, start = @start, end = @end WHERE appointmentId = @appointmentId;";
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = updateCommand;
				cmd.Parameters.AddWithValue("@appointmentId", apptInfo.appointmentId);
				cmd.Parameters.AddWithValue("@customerId", apptInfo.customerId);
				cmd.Parameters.AddWithValue("@userId", apptInfo.userId);
				cmd.Parameters.AddWithValue("@title", apptInfo.title);
				cmd.Parameters.AddWithValue("@description", apptInfo.description);
				cmd.Parameters.AddWithValue("@location", apptInfo.location);
				cmd.Parameters.AddWithValue("@contact", apptInfo.contact);
				cmd.Parameters.AddWithValue("@type", apptInfo.type);
				cmd.Parameters.AddWithValue("@url", apptInfo.url);
				cmd.Parameters.AddWithValue("@start", apptInfo.start);
				cmd.Parameters.AddWithValue("@end", apptInfo.end);
				cmd.ExecuteNonQuery();

				success = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				success = false;
			}
			finally
			{
				conn.Close();
			}

			return success;

		}


		public bool deleteAppointment(int apptId)
		{
			MySqlConnection conn = new MySqlConnection(connectionString);

			try
			{
				conn.Open();
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
				cmd.Parameters.AddWithValue("@appointmentId", apptId);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			finally
			{
				conn.Close();
			}


			return true;


		}


		public DataTable getAllAppointments()
		{
			DataTable dt = new DataTable();

			MySqlConnection conn = new MySqlConnection(connectionString);
			string query = "Select * from appointment";
			try
			{
				conn.Open();
				using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
				{
					adapter.Fill(dt);

				}

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			finally
			{
				conn.Close();

			}

			return dt;

		}

		public DataTable getDayAppointments(string day)
		{
			DataTable dt = new DataTable();

			MySqlConnection conn = new MySqlConnection(connectionString);
			string query = "SELECT * FROM appointment WHERE DATE(start) = @day";

			try
			{
				conn.Open();

				using (MySqlCommand cmd = new MySqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@day", day);

					using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
					{
						adapter.Fill(dt);

					}
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			finally
			{
				conn.Close();

			}

			return dt;

		}


	}
}
