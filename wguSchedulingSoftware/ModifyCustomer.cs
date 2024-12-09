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

		private void cancelbtn_Click(object sender, EventArgs e)
		{
			MainScreen mainScreen = new MainScreen(currentUser);
			this.Close();
			mainScreen.Show();
		}

		private void createbtn_Click(object sender, EventArgs e)
		{
			bool textBoxesNotEmpty;

			if (string.IsNullOrWhiteSpace(nametb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(phonetb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(addresstb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(addresstb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(citytb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(zipcodetb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(countrytb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else
			{
				textBoxesNotEmpty = true;
			}

			if (textBoxesNotEmpty)
			{
				DataProcedures data = new DataProcedures();

				CustomerInformation custInfo = new CustomerInformation();
				int custId = int.Parse(searchtb.Text);

				custInfo.customerID = custId;
				custInfo.customerName = nametb.Text;
				custInfo.phone = phonetb.Text;
				custInfo.address = addresstb.Text;
				custInfo.address2 = "na";
				custInfo.city = citytb.Text;
				custInfo.postalCode = zipcodetb.Text;
				custInfo.country = countrytb.Text;

				bool insertCustomerInfo = data.saveCustomerInformation(custInfo);

				if (insertCustomerInfo)
				{
					MainScreen mainScreen = new MainScreen(currentUser);
					this.Hide();
					mainScreen.Show();
				}
			}
			else
			{
				label1.Text = "Enter text in all fields";
			}
		}
	}
}
