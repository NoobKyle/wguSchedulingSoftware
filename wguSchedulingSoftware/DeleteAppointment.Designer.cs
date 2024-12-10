namespace wguSchedulingSoftware
{
	partial class DeleteAppointment
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			button2 = new Button();
			button1 = new Button();
			searchtb = new TextBox();
			searchbtn = new Button();
			label1 = new Label();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(282, 150);
			label4.Name = "label4";
			label4.Size = new Size(22, 15);
			label4.TabIndex = 53;
			label4.Text = "Na";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(132, 150);
			label3.Name = "label3";
			label3.Size = new Size(82, 15);
			label3.TabIndex = 52;
			label3.Text = "Customer ID : ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Firebrick;
			label2.Location = new Point(96, 91);
			label2.Name = "label2";
			label2.Size = new Size(328, 21);
			label2.TabIndex = 51;
			label2.Text = "Warning : This Action Cannot Be Undone !";
			// 
			// button2
			// 
			button2.Location = new Point(282, 215);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 50;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(144, 215);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 49;
			button1.Text = "Delete";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// searchtb
			// 
			searchtb.Location = new Point(166, 38);
			searchtb.Name = "searchtb";
			searchtb.Size = new Size(191, 23);
			searchtb.TabIndex = 46;
			// 
			// searchbtn
			// 
			searchbtn.Location = new Point(363, 38);
			searchbtn.Name = "searchbtn";
			searchbtn.Size = new Size(75, 23);
			searchbtn.TabIndex = 48;
			searchbtn.Text = "Search";
			searchbtn.UseVisualStyleBackColor = true;
			searchbtn.Click += searchbtn_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(43, 41);
			label1.Name = "label1";
			label1.Size = new Size(94, 15);
			label1.TabIndex = 47;
			label1.Text = "Appointment ID";
			// 
			// DeleteAppointment
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(504, 294);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(searchtb);
			Controls.Add(searchbtn);
			Controls.Add(label1);
			Name = "DeleteAppointment";
			Text = "DeleteAppointment";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
		private Label label3;
		private Label label2;
		private Button button2;
		private Button button1;
		private TextBox searchtb;
		private Button searchbtn;
		private Label label1;
	}
}