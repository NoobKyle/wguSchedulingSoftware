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

	public partial class ModifyAppointment : Form
	{
		User currentUser;
		int apptId;
		bool validAppt;
		int custid;
		public ModifyAppointment(User user)
		{
			InitializeComponent();

			currentUser = user;
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

				int custSelected = custid;

				Appointment appt = new Appointment();
				appt.appointmentId = apptId;
				appt.customerId = custSelected;
				appt.userId = currentUser.userId;
				appt.title = titletb.Text;
				appt.description = descriptiontb.Text;
				appt.location = locationtb.Text;
				appt.contact = contacttb.Text;
				appt.type = typetb.Text;
				appt.url = urltb.Text;
				appt.start = startdatetb.Value.ToUniversalTime();
				appt.end = endDatetb.Value.ToUniversalTime();

				DataProcedures data = new DataProcedures();

				if (data.updateAppointment(appt))
				{
					MainScreen mainscreen = new MainScreen(currentUser);
					this.Close();
					mainscreen.Show();
				}
			}
		}

		private void searchbtn_Click(object sender, EventArgs e)
		{

			apptId = int.Parse(searchtb.Text);

			DataProcedures data = new DataProcedures();

			Appointment appt = data.getAppointmentInformation(apptId);

			appt.userId = currentUser.userId;
			titletb.Text = appt.title;
			descriptiontb.Text = appt.description;
			locationtb.Text = appt.location;
			contacttb.Text = appt.contact;
			typetb.Text = appt.type;
			urltb.Text = appt.url;
			startdatetb.Value = appt.start.ToLocalTime();
			endDatetb.Value = appt.end.ToLocalTime();
			custid = appt.customerId;

			searchCustomerlbl.Text = custid.ToString();
		}

		private void searchCustomerlbl_Click(object sender, EventArgs e)
		{

		}

		private void cancelbtn_Click(object sender, EventArgs e)
		{
			MainScreen mainscreen = new MainScreen(currentUser);
			mainscreen.Show();
			this.Close();
		}
	}
}
