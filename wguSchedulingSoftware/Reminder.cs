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

			MessageBox.Show(appt.title);
		}
	}
}
