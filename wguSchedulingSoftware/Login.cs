using wguSchedulingSoftware.DataModels;


namespace wguSchedulingSoftware
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataProcedures data = new DataProcedures();
			User userInfo = new User(textBox1.Text, textBox2.Text);
			userInfo.userId = data.verifyUser(userInfo);

			if(userInfo.userId != -1)
			{
				label3.Text = "The connection worked";
			}
			else
			{
				label3.Text = "Failed connection";
			}
		}
	}
}
