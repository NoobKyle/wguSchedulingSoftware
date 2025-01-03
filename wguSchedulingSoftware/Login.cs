using wguSchedulingSoftware.DataModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using Org.BouncyCastle.Asn1.BC;



namespace wguSchedulingSoftware
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();

			showCorrectLanguage();
		}

		private void showCorrectLanguage()
		{
			switch (RegionInfo.CurrentRegion.EnglishName)
			{
				case "United States":
					showInEnglish();
					break;
				case "Mexico":
					showInSpanish();
					break;
				default:
					showInEnglish();
					break;
			}
		}

		private void showInEnglish()
		{
			label4.Text = "Welcome";
			label1.Text = "User Name";
			label2.Text = "Password";
			button1.Text = "Login";
			label3.Text = "User Not Found Or Incorrect Password";
		}
		private void showInSpanish()
		{
			label4.Text = "Bienvenido";
			label1.Text = "Nombre de usuario";
			label2.Text = "Contraseņa";
			button1.Text = "Acceso";
			button2.Text = "Registro";
			label3.Text = "Usuario no encontrado o contraseņa incorrecta";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataProcedures data = new DataProcedures();
			User userInfo = new User(textBox1.Text, textBox2.Text);
			userInfo.userId = data.verifyUser(userInfo);

			if(userInfo.userId != -1)
			{
				DateTime dateTime = DateTime.Now;
				this.Hide();
				MainScreen mainScreen = new MainScreen(userInfo);
				mainScreen.Show();

				data.logUserActivity("Username: '" + userInfo.username + "'. UserID: " + userInfo.userId + ". Logged in at " + dateTime);

				// Show user appointments in the next 15 minutes.
				List<Appointment> upcomingAppts = data.checkUserReminders(userInfo.userId);
				if (upcomingAppts.Count > 0)
				{
					foreach (var appt in upcomingAppts)
					{
						Reminder apptReminder = new Reminder(appt);
						apptReminder.Show();
					}
				}

			}
			else
			{
				label3.Visible = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Register register = new Register();
			register.Show();
		}
	}
}
