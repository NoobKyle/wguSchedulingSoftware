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
	public partial class Register : Form
	{
		public Register()
		{
			InitializeComponent();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
			Login logn = new Login();
			logn.Show();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			User userInfo = new User(tbxUsername.Text, tbxPassword.Text);
			DataProcedures procedures = new DataProcedures();

			if (string.IsNullOrEmpty(tbxUsername.Text) && string.IsNullOrEmpty(tbxPassword.Text))
			{	
				label3.Visible = true;
				label3.Text = "Enter Values!";
			}
			else
			{
					if (tbxPasswordConfirm.Text.Equals(tbxPassword.Text)){
						if (procedures.registerUser(userInfo))
						{
							this.Hide();
							Login logn = new Login();
							logn.Show();
						}
					}
					else
					{
						label3.Visible = true;
						label3.Text = "PASSWORDS DO NOT MATCH!";
					}
			}
		}
	}
}
