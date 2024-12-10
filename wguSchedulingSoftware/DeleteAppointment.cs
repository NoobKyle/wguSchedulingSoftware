using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using wguSchedulingSoftware.DataModels;


namespace wguSchedulingSoftware
{
	public partial class DeleteAppointment : Form
	{
		int apptId;
		int custid;
		User currentUser;
		public DeleteAppointment(User user)
		{

			InitializeComponent();
			currentUser = user;
		}

		private void searchbtn_Click(object sender, EventArgs e)
		{
			apptId = int.Parse(searchtb.Text);

			DataProcedures data = new DataProcedures();

			Appointment appt = data.getAppointmentInformation(apptId);

			custid = appt.customerId;

			label4.Text = custid.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MainScreen mainscreen = new MainScreen(currentUser);
			mainscreen.Show();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataProcedures data = new DataProcedures();

			data.deleteAppointment(apptId);
			MainScreen mainscreen = new MainScreen(currentUser);
			mainscreen.Show();
			this.Close();
		}
	}
}
