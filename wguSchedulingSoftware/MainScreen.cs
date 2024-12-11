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
using static System.Runtime.InteropServices.JavaScript.JSType;


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

			dataGridView1.DataSource = data.getAllAppointments();
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
			DeleteAppointment deleteAppointment = new DeleteAppointment(currentUser);
			this.Close();
			deleteAppointment.Show();
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

		private void updatebtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			ModifyCustomer modifyCust = new ModifyCustomer(currentUser);
			modifyCust.Show();
		}

		private void deletebtn_Click(object sender, EventArgs e)
		{
			DeleteCustomer deleteCustomer = new DeleteCustomer(currentUser);
			deleteCustomer.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			AddAppointment addapt = new AddAppointment(currentUser);
			this.Hide();
			addapt.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Close();
			ModifyAppointment modifyAppointment = new ModifyAppointment(currentUser);
			modifyAppointment.Show();
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
		{

		}

		private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{	
			DataProcedures data = new DataProcedures();
			dataGridView1.DataSource = data.getDayAppointments(e.Start.ToString("yyyy-MM-dd"));
		}
	}
}
