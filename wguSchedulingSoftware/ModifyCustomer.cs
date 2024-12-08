//using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class ModifyCustomer : Form
	{
		User currentUser;
		public ModifyCustomer(User user)
		{
			InitializeComponent();
			currentUser = user;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void searchbtn_Click(object sender, EventArgs e)
		{
			int custId = int.Parse(searchtb.Text);

			DataProcedures data = new DataProcedures();

			CustomerInformation custInfo = data.getCustomerInformation(custId);

			nametb.Text = custInfo.customerName;
			phonetb.Text = custInfo.phone;
			addresstb.Text = custInfo.address;
			zipcodetb.Text = custInfo.postalCode;
			countrytb.Text = custInfo.country;
			citytb.Text = custInfo.city;
		}
	}
}
