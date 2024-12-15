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
	public partial class Reminder : Form
	{
		public Reminder(Appointment appt)
		{
			InitializeComponent();

			DataProcedures data = new DataProcedures();
			string customerName = data.getCustomerInformation(appt.customerId).customerName;


			label11.Text = customerName;
			label12.Text = appt.title;
			label13.Text = appt.description;
			label14.Text = appt.location;
			label15.Text = appt.contact;
			label16.Text = appt.type;
			label17.Text = appt.url;
			label18.Text = appt.start.ToString();
			label19.Text = appt.end.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}



// customer name
// title
// description
//location
//contact
//type
//url
//start
//end