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
	public partial class MainScreen : Form
	{
		User currentUser;
		public MainScreen(User user)
		{
			InitializeComponent();

			currentUser = new User();
			currentUser = user;

			DataProcedures data = new DataProcedures();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void MainScreen_Load(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void createbtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddCustomer addCust = new AddCustomer(currentUser);
			addCust.Show();
		}
	}
}
