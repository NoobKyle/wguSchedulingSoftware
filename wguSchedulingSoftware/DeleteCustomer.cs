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
	public partial class DeleteCustomer : Form
	{
		User currentUser;
		public DeleteCustomer(User currentUser)
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MainScreen mainscreen = new MainScreen(currentUser);
			mainscreen.Show();
			this.Close();
		}

		private void searchbtn_Click(object sender, EventArgs e)
		{
			int custId = int.Parse(searchtb.Text);

			DataProcedures data = new DataProcedures();

			CustomerInformation custInfo = data.getCustomerInformation(custId);

			label4.Text = custInfo.customerName;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(searchtb.Text != "")
			{
				DataProcedures data = new DataProcedures();
				int custId = int.Parse(searchtb.Text);
				data.deleteCustomer(custId);

				MainScreen mainscreen = new MainScreen(currentUser);
				mainscreen.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Select a customer Id to delete");
			}
		}
	}
}
