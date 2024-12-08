namespace wguSchedulingSoftware
{
	partial class ModifyCustomer
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
			nocb = new CheckBox();
			yescb = new CheckBox();
			cancelbtn = new Button();
			createbtn = new Button();
			countrytb = new TextBox();
			zipcodetb = new TextBox();
			citytb = new TextBox();
			addresstb = new TextBox();
			phonetb = new TextBox();
			nametb = new TextBox();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			searchbtn = new Button();
			searchtb = new TextBox();
			SuspendLayout();
			// 
			// nocb
			// 
			nocb.AutoSize = true;
			nocb.Location = new Point(278, 402);
			nocb.Name = "nocb";
			nocb.Size = new Size(42, 19);
			nocb.TabIndex = 32;
			nocb.Text = "No";
			nocb.UseVisualStyleBackColor = true;
			// 
			// yescb
			// 
			yescb.AutoSize = true;
			yescb.Location = new Point(173, 401);
			yescb.Name = "yescb";
			yescb.Size = new Size(43, 19);
			yescb.TabIndex = 31;
			yescb.Text = "Yes";
			yescb.UseVisualStyleBackColor = true;
			// 
			// cancelbtn
			// 
			cancelbtn.Location = new Point(278, 487);
			cancelbtn.Name = "cancelbtn";
			cancelbtn.Size = new Size(75, 30);
			cancelbtn.TabIndex = 34;
			cancelbtn.Text = "Cancel";
			cancelbtn.UseVisualStyleBackColor = true;
			// 
			// createbtn
			// 
			createbtn.Location = new Point(104, 487);
			createbtn.Name = "createbtn";
			createbtn.Size = new Size(75, 30);
			createbtn.TabIndex = 33;
			createbtn.Text = "Modify";
			createbtn.UseVisualStyleBackColor = true;
			// 
			// countrytb
			// 
			countrytb.Location = new Point(173, 347);
			countrytb.Name = "countrytb";
			countrytb.Size = new Size(180, 23);
			countrytb.TabIndex = 30;
			// 
			// zipcodetb
			// 
			zipcodetb.Location = new Point(173, 300);
			zipcodetb.Name = "zipcodetb";
			zipcodetb.Size = new Size(180, 23);
			zipcodetb.TabIndex = 29;
			// 
			// citytb
			// 
			citytb.Location = new Point(173, 256);
			citytb.Name = "citytb";
			citytb.Size = new Size(180, 23);
			citytb.TabIndex = 28;
			// 
			// addresstb
			// 
			addresstb.Location = new Point(173, 205);
			addresstb.Name = "addresstb";
			addresstb.Size = new Size(180, 23);
			addresstb.TabIndex = 27;
			// 
			// phonetb
			// 
			phonetb.Location = new Point(173, 153);
			phonetb.Name = "phonetb";
			phonetb.Size = new Size(180, 23);
			phonetb.TabIndex = 26;
			// 
			// nametb
			// 
			nametb.Location = new Point(173, 104);
			nametb.Name = "nametb";
			nametb.Size = new Size(180, 23);
			nametb.TabIndex = 25;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(63, 402);
			label8.Name = "label8";
			label8.Size = new Size(40, 15);
			label8.TabIndex = 24;
			label8.Text = "Active";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(63, 350);
			label7.Name = "label7";
			label7.Size = new Size(59, 15);
			label7.TabIndex = 23;
			label7.Text = "Country : ";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(63, 303);
			label6.Name = "label6";
			label6.Size = new Size(64, 15);
			label6.TabIndex = 22;
			label6.Text = "Zip Code : ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(63, 259);
			label5.Name = "label5";
			label5.Size = new Size(34, 15);
			label5.TabIndex = 21;
			label5.Text = "City :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(63, 208);
			label4.Name = "label4";
			label4.Size = new Size(55, 15);
			label4.TabIndex = 20;
			label4.Text = "Address :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(63, 161);
			label3.Name = "label3";
			label3.Size = new Size(50, 15);
			label3.TabIndex = 19;
			label3.Text = "Phone : ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(63, 107);
			label2.Name = "label2";
			label2.Size = new Size(48, 15);
			label2.TabIndex = 18;
			label2.Text = "Name : ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(17, 44);
			label1.Name = "label1";
			label1.Size = new Size(117, 15);
			label1.TabIndex = 35;
			label1.Text = "Search For Customer";
			label1.Click += label1_Click;
			// 
			// searchbtn
			// 
			searchbtn.Location = new Point(337, 41);
			searchbtn.Name = "searchbtn";
			searchbtn.Size = new Size(75, 23);
			searchbtn.TabIndex = 36;
			searchbtn.Text = "Search";
			searchbtn.UseVisualStyleBackColor = true;
			searchbtn.Click += searchbtn_Click;
			// 
			// searchtb
			// 
			searchtb.Location = new Point(140, 41);
			searchtb.Name = "searchtb";
			searchtb.Size = new Size(191, 23);
			searchtb.TabIndex = 37;
			// 
			// ModifyCustomer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(434, 586);
			Controls.Add(searchtb);
			Controls.Add(searchbtn);
			Controls.Add(label1);
			Controls.Add(nocb);
			Controls.Add(yescb);
			Controls.Add(cancelbtn);
			Controls.Add(createbtn);
			Controls.Add(countrytb);
			Controls.Add(zipcodetb);
			Controls.Add(citytb);
			Controls.Add(addresstb);
			Controls.Add(phonetb);
			Controls.Add(nametb);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Name = "ModifyCustomer";
			Text = "ModifyCustomer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox nocb;
		private CheckBox yescb;
		private Button cancelbtn;
		private Button createbtn;
		private TextBox countrytb;
		private TextBox zipcodetb;
		private TextBox citytb;
		private TextBox addresstb;
		private TextBox phonetb;
		private TextBox nametb;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button searchbtn;
		private TextBox searchtb;
	}
}