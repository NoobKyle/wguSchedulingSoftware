namespace wguSchedulingSoftware
{
	partial class DeleteCustomer
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
			searchtb = new TextBox();
			searchbtn = new Button();
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			SuspendLayout();
			// 
			// searchtb
			// 
			searchtb.Location = new Point(148, 32);
			searchtb.Name = "searchtb";
			searchtb.Size = new Size(191, 23);
			searchtb.TabIndex = 0;
			// 
			// searchbtn
			// 
			searchbtn.Location = new Point(345, 32);
			searchbtn.Name = "searchbtn";
			searchbtn.Size = new Size(75, 23);
			searchbtn.TabIndex = 39;
			searchbtn.Text = "Search";
			searchbtn.UseVisualStyleBackColor = true;
			searchbtn.Click += searchbtn_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(25, 35);
			label1.Name = "label1";
			label1.Size = new Size(117, 15);
			label1.TabIndex = 38;
			label1.Text = "Search For Customer";
			// 
			// button1
			// 
			button1.Location = new Point(126, 209);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 41;
			button1.Text = "Delete";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(264, 209);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 42;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Firebrick;
			label2.Location = new Point(78, 85);
			label2.Name = "label2";
			label2.Size = new Size(328, 21);
			label2.TabIndex = 43;
			label2.Text = "Warning : This Action Cannot Be Undone !";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(114, 144);
			label3.Name = "label3";
			label3.Size = new Size(103, 15);
			label3.TabIndex = 44;
			label3.Text = "Customer Name : ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(264, 144);
			label4.Name = "label4";
			label4.Size = new Size(22, 15);
			label4.TabIndex = 45;
			label4.Text = "Na";
			// 
			// DeleteCustomer
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(503, 294);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(searchtb);
			Controls.Add(searchbtn);
			Controls.Add(label1);
			Name = "DeleteCustomer";
			Text = "DeleteCustomer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox searchtb;
		private Button searchbtn;
		private Label label1;
		private Button button1;
		private Button button2;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}