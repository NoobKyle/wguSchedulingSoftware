namespace wguSchedulingSoftware
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label4 = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(54, 240);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(59, 93);
			label1.Name = "label1";
			label1.Size = new Size(65, 15);
			label1.TabIndex = 1;
			label1.Text = "User Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(59, 162);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 2;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Brown;
			label3.Location = new Point(49, 298);
			label3.Name = "label3";
			label3.Size = new Size(280, 15);
			label3.TabIndex = 3;
			label3.Text = "USER NOT FOUND OR INCORRECT PASSWORD";
			label3.Visible = false;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(49, 111);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(255, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(49, 190);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(255, 23);
			textBox2.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(98, 25);
			label4.Name = "label4";
			label4.Size = new Size(167, 45);
			label4.TabIndex = 6;
			label4.Text = "Welcome ";
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Location = new Point(190, 240);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 7;
			button2.Text = "Register";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(355, 361);
			Controls.Add(button2);
			Controls.Add(label4);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Scheduling Software";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label4;
		private Button button2;
	}
}
