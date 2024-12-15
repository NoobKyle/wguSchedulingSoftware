using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wguSchedulingSoftware.DataModels;

namespace wguSchedulingSoftware
{
	public partial class AddAppointment : Form
	{
		User currentUser;
		bool validAppt;
		public AddAppointment(User user)
		{
			InitializeComponent();
			currentUser = new User();
			currentUser.username = user.username;
			currentUser.userId = user.userId;

			DataProcedures data = new DataProcedures();

			startdatetb.Format = DateTimePickerFormat.Time;
			endDatetb.Format = DateTimePickerFormat.Time;

			
		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void AddAppointment_Load(object sender, EventArgs e)
		{

		}

		private void cancelbtn_Click(object sender, EventArgs e)
		{
			MainScreen mainscreen = new MainScreen(currentUser);
			this.Close();
			mainscreen.Show();
		}

		private void createbtn_Click(object sender, EventArgs e)
		{
			bool textBoxesNotEmpty;

			if (string.IsNullOrWhiteSpace(titletb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(descriptiontb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(locationtb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(contacttb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(typetb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(urltb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else
			{
				textBoxesNotEmpty = true;
			}

			if (textBoxesNotEmpty)
			{
				int custSelected = int.Parse(searchtb.Text);
				Appointment appt = new Appointment();
				appt.customerId = custSelected;
				appt.userId = currentUser.userId;
				appt.title = titletb.Text;
				appt.description = descriptiontb.Text;
				appt.location = locationtb.Text;
				appt.contact = contacttb.Text;
				appt.type = typetb.Text;
				appt.url = urltb.Text;
				appt.start = startdatetb.Value.ToUniversalTime();//all times are stored and compared as UTC, and displayed to the user in their local time.
				appt.end = endDatetb.Value.ToUniversalTime();

				DataProcedures data = new DataProcedures();

				if (data.addAppointment(appt) != -1)
				{
					MainScreen mainScreen = new MainScreen(currentUser);
					this.Hide();
					mainScreen.Show();
				}
			}
			else
			{
				MessageBox.Show("Enter all field values!");
			}
		}

		private void searchbtn_Click(object sender, EventArgs e)
		{
			int custId = int.Parse(searchtb.Text);

			DataProcedures data = new DataProcedures();

			CustomerInformation custInfo = data.getCustomerInformation(custId);

			searchCustomerlbl.Text = custInfo.customerName;
		}
	}
}
