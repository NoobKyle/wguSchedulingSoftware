namespace wguSchedulingSoftware
{
	partial class AddCustomer
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			nametb = new TextBox();
			phonetb = new TextBox();
			addresstb = new TextBox();
			citytb = new TextBox();
			zipcodetb = new TextBox();
			countrytb = new TextBox();
			createbtn = new Button();
			cancelbtn = new Button();
			yescb = new CheckBox();
			nocb = new CheckBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(120, 35);
			label1.Name = "label1";
			label1.Size = new Size(174, 20);
			label1.TabIndex = 0;
			label1.Text = "Create Customer Record";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(67, 103);
			label2.Name = "label2";
			label2.Size = new Size(48, 15);
			label2.TabIndex = 1;
			label2.Text = "Name : ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(67, 157);
			label3.Name = "label3";
			label3.Size = new Size(50, 15);
			label3.TabIndex = 2;
			label3.Text = "Phone : ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(67, 204);
			label4.Name = "label4";
			label4.Size = new Size(55, 15);
			label4.TabIndex = 3;
			label4.Text = "Address :";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(67, 255);
			label5.Name = "label5";
			label5.Size = new Size(34, 15);
			label5.TabIndex = 4;
			label5.Text = "City :";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(67, 299);
			label6.Name = "label6";
			label6.Size = new Size(64, 15);
			label6.TabIndex = 5;
			label6.Text = "Zip Code : ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(67, 346);
			label7.Name = "label7";
			label7.Size = new Size(59, 15);
			label7.TabIndex = 6;
			label7.Text = "Country : ";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(67, 398);
			label8.Name = "label8";
			label8.Size = new Size(40, 15);
			label8.TabIndex = 7;
			label8.Text = "Active";
			// 
			// nametb
			// 
			nametb.Location = new Point(177, 100);
			nametb.Name = "nametb";
			nametb.Size = new Size(180, 23);
			nametb.TabIndex = 8;
			// 
			// phonetb
			// 
			phonetb.Location = new Point(177, 149);
			phonetb.Name = "phonetb";
			phonetb.Size = new Size(180, 23);
			phonetb.TabIndex = 9;
			phonetb.TextChanged += textBox2_TextChanged;
			// 
			// addresstb
			// 
			addresstb.Location = new Point(177, 201);
			addresstb.Name = "addresstb";
			addresstb.Size = new Size(180, 23);
			addresstb.TabIndex = 10;
			// 
			// citytb
			// 
			citytb.Location = new Point(177, 252);
			citytb.Name = "citytb";
			citytb.Size = new Size(180, 23);
			citytb.TabIndex = 11;
			// 
			// zipcodetb
			// 
			zipcodetb.Location = new Point(177, 296);
			zipcodetb.Name = "zipcodetb";
			zipcodetb.Size = new Size(180, 23);
			zipcodetb.TabIndex = 12;
			// 
			// countrytb
			// 
			countrytb.Location = new Point(177, 343);
			countrytb.Name = "countrytb";
			countrytb.Size = new Size(180, 23);
			countrytb.TabIndex = 13;
			// 
			// createbtn
			// 
			createbtn.Location = new Point(108, 483);
			createbtn.Name = "createbtn";
			createbtn.Size = new Size(75, 30);
			createbtn.TabIndex = 16;
			createbtn.Text = "Create";
			createbtn.UseVisualStyleBackColor = true;
			createbtn.Click += button1_Click;
			// 
			// cancelbtn
			// 
			cancelbtn.Location = new Point(282, 483);
			cancelbtn.Name = "cancelbtn";
			cancelbtn.Size = new Size(75, 30);
			cancelbtn.TabIndex = 17;
			cancelbtn.Text = "Cancel";
			cancelbtn.UseVisualStyleBackColor = true;
			// 
			// yescb
			// 
			yescb.AutoSize = true;
			yescb.Location = new Point(176, 404);
			yescb.Name = "yescb";
			yescb.Size = new Size(43, 19);
			yescb.TabIndex = 14;
			yescb.Text = "Yes";
			yescb.UseVisualStyleBackColor = true;
			// 
			// nocb
			// 
			nocb.AutoSize = true;
			nocb.Location = new Point(274, 404);
			nocb.Name = "nocb";
			nocb.Size = new Size(42, 19);
			nocb.TabIndex = 15;
			nocb.Text = "No";
			nocb.UseVisualStyleBackColor = true;
			// 
			// AddCustomer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(433, 586);
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
			Controls.Add(label1);
			Name = "AddCustomer";
			Text = "AddCustomer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox nametb;
		private TextBox phonetb;
		private TextBox addresstb;
		private TextBox citytb;
		private TextBox zipcodetb;
		private TextBox countrytb;
		private Button createbtn;
		private Button cancelbtn;
		private CheckBox yescb;
		private CheckBox nocb;
	}
}