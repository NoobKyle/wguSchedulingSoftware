namespace wguSchedulingSoftware
{
	partial class Register
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
			label6 = new Label();
			button2 = new Button();
			tbxPasswordConfirm = new TextBox();
			tbxUsername = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnRegister = new Button();
			tbxPassword = new TextBox();
			label4 = new Label();
			SuspendLayout();
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(94, 31);
			label6.Name = "label6";
			label6.Size = new Size(142, 45);
			label6.TabIndex = 7;
			label6.Text = "Register";
			label6.Click += label6_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Location = new Point(173, 270);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 4;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// tbxPasswordConfirm
			// 
			tbxPasswordConfirm.Location = new Point(33, 220);
			tbxPasswordConfirm.Name = "tbxPasswordConfirm";
			tbxPasswordConfirm.Size = new Size(255, 23);
			tbxPasswordConfirm.TabIndex = 2;
			// 
			// tbxUsername
			// 
			tbxUsername.Location = new Point(33, 102);
			tbxUsername.Name = "tbxUsername";
			tbxUsername.Size = new Size(255, 23);
			tbxUsername.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Brown;
			label3.Location = new Point(33, 328);
			label3.Name = "label3";
			label3.Size = new Size(189, 15);
			label3.TabIndex = 12;
			label3.Text = "PASSWORDS DO NOT MATCH!";
			label3.Visible = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(43, 192);
			label2.Name = "label2";
			label2.Size = new Size(104, 15);
			label2.TabIndex = 11;
			label2.Text = "Confirm Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(43, 84);
			label1.Name = "label1";
			label1.Size = new Size(65, 15);
			label1.TabIndex = 9;
			label1.Text = "User Name";
			// 
			// btnRegister
			// 
			btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnRegister.Location = new Point(38, 270);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(75, 23);
			btnRegister.TabIndex = 3;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// tbxPassword
			// 
			tbxPassword.Location = new Point(33, 155);
			tbxPassword.Name = "tbxPassword";
			tbxPassword.Size = new Size(255, 23);
			tbxPassword.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(43, 137);
			label4.Name = "label4";
			label4.Size = new Size(57, 15);
			label4.TabIndex = 16;
			label4.Text = "Password";
			label4.Click += label4_Click;
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(355, 361);
			Controls.Add(tbxPassword);
			Controls.Add(label4);
			Controls.Add(button2);
			Controls.Add(tbxPasswordConfirm);
			Controls.Add(tbxUsername);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnRegister);
			Controls.Add(label6);
			Name = "Register";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Register";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label6;
		private Button button2;
		private TextBox tbxPasswordConfirm;
		private TextBox tbxUsername;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button btnRegister;
		private TextBox tbxPassword;
		private Label label4;
	}
}