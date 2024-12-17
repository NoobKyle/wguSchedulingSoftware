using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wguSchedulingSoftware.DataModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace wguSchedulingSoftware
{
	public partial class Reports : Form
	{
		User currentUser;
		public Reports(User user,int r)
		{
			InitializeComponent();

			currentUser = new User();
			currentUser = user;

			switch(r){
				case 1:
					apptTypes();
					break;
				case 2:
					schedules();
					break;
				case 3: 
					customers(); 
					break;
				default:
					break;
			}
		}

		private void Reports_Load(object sender, EventArgs e)
		{
			
		}

		public void apptTypes()
		{
			DataProcedures data = new DataProcedures();
			textBox1.Text = string.Empty;

			string resultString = string.Empty;

			for (int i = 1; i <= 12; i++)
			{
				List<string> list = data.returnApptTypesMonth(currentUser.userId, i);
				var q = from x in list
						group x by x into g
						let count = g.Count()
						orderby count descending
						select new { Value = g.Key, Count = count };

				resultString += Environment.NewLine + DateTimeFormatInfo.CurrentInfo.GetMonthName(i) + Environment.NewLine;
				foreach (var x in q)
				{
					resultString += x.Count + "\t Type:  " + x.Value + Environment.NewLine;
				}
			}

			textBox1.Text = resultString;
		}

		private void schedules()
		{
			DataProcedures data = new DataProcedures();
			label1.Text = "Consultants schedule";
			textBox1.Text = string.Empty;

			string resultString = string.Empty;

			List<int> userIdsDistinct = data.returnDistinctConsultantsWithAppts();

			userIdsDistinct.ForEach(varid =>
			{
				//lambda function.
				List<Appointment> consultantAppts = data.returnUserSchedule(varid);
				resultString += "\n\nAppointments for USER :  " + varid + Environment.NewLine + Environment.NewLine;
				consultantAppts.ForEach(appt =>
				{//lambda used to make foreach simpler
					resultString += "\nStart: " + appt.start + "   End: " + appt.end + Environment.NewLine;
				});
			});

			textBox1.Text = resultString;
		}


		private void customers()
		{
			DataProcedures data = new DataProcedures();
			label1.Text = "Customers In DB : ";
			textBox1.Text = string.Empty;

			string resultString = string.Empty;
			resultString += "\n\n ID" + "\t Name " + "\t Active " + " "  + Environment.NewLine + Environment.NewLine;

			List<Customer> customerList = data.returnCustomerList();
			customerList.ForEach(customer =>
			{
				resultString += " " + customer.customerId + "\t " + customer.customerName + "\t " + customer.active + Environment.NewLine;
			});

			textBox1.Text = resultString;
		}


	}
}
