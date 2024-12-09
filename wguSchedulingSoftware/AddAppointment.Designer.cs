namespace wguSchedulingSoftware
{
	partial class AddAppointment
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
			cancelbtn = new Button();
			createbtn = new Button();
			urltb = new TextBox();
			contacttb = new TextBox();
			locationtb = new TextBox();
			typetb = new TextBox();
			titletb = new TextBox();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			searchtb = new TextBox();
			searchbtn = new Button();
			label9 = new Label();
			searchCustomerlbl = new Label();
			label11 = new Label();
			descriptiontb = new TextBox();
			label12 = new Label();
			startdatetb = new DateTimePicker();
			endDatetb = new DateTimePicker();
			SuspendLayout();
			// 
			// cancelbtn
			// 
			cancelbtn.Location = new Point(251, 555);
			cancelbtn.Name = "cancelbtn";
			cancelbtn.Size = new Size(75, 30);
			cancelbtn.TabIndex = 11;
			cancelbtn.Text = "Cancel";
			cancelbtn.UseVisualStyleBackColor = true;
			cancelbtn.Click += cancelbtn_Click;
			// 
			// createbtn
			// 
			createbtn.Location = new Point(64, 555);
			createbtn.Name = "createbtn";
			createbtn.Size = new Size(75, 30);
			createbtn.TabIndex = 10;
			createbtn.Text = "Create";
			createbtn.UseVisualStyleBackColor = true;
			createbtn.Click += createbtn_Click;
			// 
			// urltb
			// 
			urltb.Location = new Point(114, 398);
			urltb.Name = "urltb";
			urltb.Size = new Size(212, 23);
			urltb.TabIndex = 6;
			// 
			// contacttb
			// 
			contacttb.Location = new Point(114, 349);
			contacttb.Name = "contacttb";
			contacttb.Size = new Size(212, 23);
			contacttb.TabIndex = 5;
			// 
			// locationtb
			// 
			locationtb.Location = new Point(114, 305);
			locationtb.Name = "locationtb";
			locationtb.Size = new Size(212, 23);
			locationtb.TabIndex = 4;
			// 
			// typetb
			// 
			typetb.Location = new Point(114, 260);
			typetb.Name = "typetb";
			typetb.Size = new Size(212, 23);
			typetb.TabIndex = 3;
			// 
			// titletb
			// 
			titletb.Location = new Point(38, 211);
			titletb.Name = "titletb";
			titletb.Size = new Size(288, 23);
			titletb.TabIndex = 2;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(372, 183);
			label8.Name = "label8";
			label8.Size = new Size(73, 15);
			label8.TabIndex = 25;
			label8.Text = "Description :";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(38, 456);
			label7.Name = "label7";
			label7.Size = new Size(64, 15);
			label7.TabIndex = 24;
			label7.Text = "Start Date :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(38, 406);
			label6.Name = "label6";
			label6.Size = new Size(31, 15);
			label6.TabIndex = 23;
			label6.Text = "Url : ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(38, 352);
			label5.Name = "label5";
			label5.Size = new Size(55, 15);
			label5.TabIndex = 22;
			label5.Text = "Contact :";
			label5.Click += label5_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(38, 308);
			label4.Name = "label4";
			label4.Size = new Size(62, 15);
			label4.TabIndex = 21;
			label4.Text = "Location : ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(36, 263);
			label3.Name = "label3";
			label3.Size = new Size(37, 15);
			label3.TabIndex = 20;
			label3.Text = "Type :";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(36, 177);
			label2.Name = "label2";
			label2.Size = new Size(54, 21);
			label2.TabIndex = 19;
			label2.Text = "Title : ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(36, 26);
			label1.Name = "label1";
			label1.Size = new Size(182, 20);
			label1.TabIndex = 18;
			label1.Text = "Create New Appointment";
			// 
			// searchtb
			// 
			searchtb.Location = new Point(175, 64);
			searchtb.Name = "searchtb";
			searchtb.Size = new Size(191, 23);
			searchtb.TabIndex = 0;
			// 
			// searchbtn
			// 
			searchbtn.Location = new Point(372, 64);
			searchbtn.Name = "searchbtn";
			searchbtn.Size = new Size(75, 23);
			searchbtn.TabIndex = 1;
			searchbtn.Text = "Search";
			searchbtn.UseVisualStyleBackColor = true;
			searchbtn.Click += searchbtn_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.Location = new Point(36, 67);
			label9.Name = "label9";
			label9.Size = new Size(133, 15);
			label9.TabIndex = 41;
			label9.Text = "Search For Customer ID";
			// 
			// searchCustomerlbl
			// 
			searchCustomerlbl.AutoSize = true;
			searchCustomerlbl.Location = new Point(190, 113);
			searchCustomerlbl.Name = "searchCustomerlbl";
			searchCustomerlbl.Size = new Size(22, 15);
			searchCustomerlbl.TabIndex = 47;
			searchCustomerlbl.Text = "Na";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(36, 113);
			label11.Name = "label11";
			label11.Size = new Size(103, 15);
			label11.TabIndex = 46;
			label11.Text = "Customer Name : ";
			label11.Click += label11_Click;
			// 
			// descriptiontb
			// 
			descriptiontb.Location = new Point(372, 211);
			descriptiontb.Multiline = true;
			descriptiontb.Name = "descriptiontb";
			descriptiontb.Size = new Size(610, 352);
			descriptiontb.TabIndex = 9;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(38, 498);
			label12.Name = "label12";
			label12.Size = new Size(60, 15);
			label12.TabIndex = 49;
			label12.Text = "End Date :";
			// 
			// startdatetb
			// 
			startdatetb.Location = new Point(114, 450);
			startdatetb.Name = "startdatetb";
			startdatetb.Size = new Size(212, 23);
			startdatetb.TabIndex = 7;
			// 
			// endDatetb
			// 
			endDatetb.Location = new Point(114, 498);
			endDatetb.Name = "endDatetb";
			endDatetb.Size = new Size(212, 23);
			endDatetb.TabIndex = 8;
			// 
			// AddAppointment
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1001, 608);
			Controls.Add(endDatetb);
			Controls.Add(startdatetb);
			Controls.Add(label12);
			Controls.Add(descriptiontb);
			Controls.Add(searchCustomerlbl);
			Controls.Add(label11);
			Controls.Add(searchtb);
			Controls.Add(searchbtn);
			Controls.Add(label9);
			Controls.Add(cancelbtn);
			Controls.Add(createbtn);
			Controls.Add(urltb);
			Controls.Add(contacttb);
			Controls.Add(locationtb);
			Controls.Add(typetb);
			Controls.Add(titletb);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AddAppointment";
			Text = "AddAppointment";
			Load += AddAppointment_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button cancelbtn;
		private Button createbtn;
		private TextBox urltb;
		private TextBox contacttb;
		private TextBox locationtb;
		private TextBox typetb;
		private TextBox titletb;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox searchtb;
		private Button searchbtn;
		private Label label9;
		private Label searchCustomerlbl;
		private Label label11;
		private TextBox descriptiontb;
		private Label label12;
		private DateTimePicker startdatetb;
		private DateTimePicker endDatetb;
	}
}