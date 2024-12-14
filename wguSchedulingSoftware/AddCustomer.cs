using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using wguSchedulingSoftware.DataModels;

namespace wguSchedulingSoftware
{
	public partial class AddCustomer : Form
	{
		User currentUser;
		public AddCustomer(User user)
		{
			InitializeComponent();
			currentUser = new User();
			currentUser.username = user.username;
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			string phonetxt = phonetb.Text;

			string validText = System.Text.RegularExpressions.Regex.Replace(phonetxt, @"[^0-9-]", "");

			if (phonetxt != validText)
			{
				phonetb.Text = validText;

				phonetb.SelectionStart = phonetb.Text.Length;
			}
		}

		private void button1_Click(object sender, EventArgs e)
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
			else if (string.IsNullOrWhiteSpace(citytb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(countrytb.Text))
			{
				textBoxesNotEmpty = false;
			}
			else if (string.IsNullOrWhiteSpace(zipcodetb.Text))
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

				Customer customer = new Customer();
				Address address = new Address();
				City city = new City();
				Country country = new Country();

				customer.customerName = nametb.Text;

				customer.createdBy = currentUser.username;
				address.createdBy = currentUser.username;
				city.createdBy = currentUser.username;
				country.createdBy = currentUser.username;

				address.address = addresstb.Text;
				address.address2 = addresstb.Text;
				address.postalCode = zipcodetb.Text;
				address.phone = phonetb.Text;

				city.city = citytb.Text;

				country.country = countrytb.Text;

				city.countryId = data.addCountry(country);
				address.cityId = data.addCity(city);
				customer.addressId = data.addAddress(address);

				if (data.addCustomer(customer))
				{
					MainScreen mainscreen = new MainScreen(currentUser);
					this.Hide();
					mainscreen.Show();
				}
			}
			else
			{
				label1.Text = "Fill all Fields";
			}

		}

		private void cancelbtn_Click(object sender, EventArgs e)
		{
			MainScreen mainScreen = new MainScreen(currentUser);
			this.Hide();
			mainScreen.Show();
		}
	}
}
