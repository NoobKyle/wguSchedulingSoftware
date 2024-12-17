namespace wguSchedulingSoftware
{
	partial class MainScreen
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
			createbtn = new Button();
			updatebtn = new Button();
			deletebtn = new Button();
			numberOfAppointmentsbtn = new Button();
			consultantsSchedulesbtn = new Button();
			customerReportsbtn = new Button();
			button7 = new Button();
			button8 = new Button();
			button9 = new Button();
			dataGridView1 = new DataGridView();
			monthCalendar1 = new MonthCalendar();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(382, 9);
			label1.Name = "label1";
			label1.Size = new Size(211, 50);
			label1.TabIndex = 0;
			label1.Text = "Dashboard";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
			label2.Location = new Point(9, 117);
			label2.Name = "label2";
			label2.Size = new Size(175, 30);
			label2.TabIndex = 1;
			label2.Text = "Customer Access";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
			label3.Location = new Point(223, 117);
			label3.Name = "label3";
			label3.Size = new Size(88, 30);
			label3.TabIndex = 2;
			label3.Text = "Reports";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
			label4.Location = new Point(588, 114);
			label4.Name = "label4";
			label4.Size = new Size(231, 30);
			label4.TabIndex = 3;
			label4.Text = "Appointment Calendar";
			// 
			// createbtn
			// 
			createbtn.Location = new Point(33, 163);
			createbtn.Name = "createbtn";
			createbtn.Size = new Size(90, 23);
			createbtn.TabIndex = 4;
			createbtn.Text = "Create";
			createbtn.UseVisualStyleBackColor = true;
			createbtn.Click += createbtn_Click;
			// 
			// updatebtn
			// 
			updatebtn.Location = new Point(33, 216);
			updatebtn.Name = "updatebtn";
			updatebtn.Size = new Size(90, 23);
			updatebtn.TabIndex = 5;
			updatebtn.Text = "Update";
			updatebtn.UseVisualStyleBackColor = true;
			updatebtn.Click += updatebtn_Click;
			// 
			// deletebtn
			// 
			deletebtn.Location = new Point(33, 272);
			deletebtn.Name = "deletebtn";
			deletebtn.Size = new Size(90, 23);
			deletebtn.TabIndex = 6;
			deletebtn.Text = "Delete";
			deletebtn.UseVisualStyleBackColor = true;
			deletebtn.Click += deletebtn_Click;
			// 
			// numberOfAppointmentsbtn
			// 
			numberOfAppointmentsbtn.Location = new Point(176, 163);
			numberOfAppointmentsbtn.Name = "numberOfAppointmentsbtn";
			numberOfAppointmentsbtn.Size = new Size(180, 23);
			numberOfAppointmentsbtn.TabIndex = 7;
			numberOfAppointmentsbtn.Text = "Number Of Appointments";
			numberOfAppointmentsbtn.UseVisualStyleBackColor = true;
			numberOfAppointmentsbtn.Click += numberOfAppointmentsbtn_Click;
			// 
			// consultantsSchedulesbtn
			// 
			consultantsSchedulesbtn.Location = new Point(176, 216);
			consultantsSchedulesbtn.Name = "consultantsSchedulesbtn";
			consultantsSchedulesbtn.Size = new Size(180, 23);
			consultantsSchedulesbtn.TabIndex = 8;
			consultantsSchedulesbtn.Text = "Consultant Schedules";
			consultantsSchedulesbtn.UseVisualStyleBackColor = true;
			consultantsSchedulesbtn.Click += consultantsSchedulesbtn_Click;
			// 
			// customerReportsbtn
			// 
			customerReportsbtn.Location = new Point(176, 272);
			customerReportsbtn.Name = "customerReportsbtn";
			customerReportsbtn.Size = new Size(180, 23);
			customerReportsbtn.TabIndex = 9;
			customerReportsbtn.Text = "Customer Reports";
			customerReportsbtn.UseVisualStyleBackColor = true;
			customerReportsbtn.Click += customerReportsbtn_Click;
			// 
			// button7
			// 
			button7.Location = new Point(551, 367);
			button7.Name = "button7";
			button7.Size = new Size(75, 23);
			button7.TabIndex = 10;
			button7.Text = "Add";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button8
			// 
			button8.Location = new Point(684, 367);
			button8.Name = "button8";
			button8.Size = new Size(75, 23);
			button8.TabIndex = 11;
			button8.Text = "Update";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button9
			// 
			button9.Location = new Point(823, 367);
			button9.Name = "button9";
			button9.Size = new Size(75, 23);
			button9.TabIndex = 12;
			button9.Text = "Delete";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(27, 431);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(990, 312);
			dataGridView1.TabIndex = 15;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// monthCalendar1
			// 
			monthCalendar1.CalendarDimensions = new Size(2, 1);
			monthCalendar1.Location = new Point(489, 163);
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 16;
			monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
			monthCalendar1.DateSelected += monthCalendar1_DateSelected;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(27, 408);
			label5.Name = "label5";
			label5.Size = new Size(105, 20);
			label5.TabIndex = 21;
			label5.Text = "Appointments";
			label5.Click += label5_Click;
			// 
			// MainScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1041, 774);
			Controls.Add(label5);
			Controls.Add(monthCalendar1);
			Controls.Add(dataGridView1);
			Controls.Add(button9);
			Controls.Add(button8);
			Controls.Add(button7);
			Controls.Add(customerReportsbtn);
			Controls.Add(consultantsSchedulesbtn);
			Controls.Add(numberOfAppointmentsbtn);
			Controls.Add(deletebtn);
			Controls.Add(updatebtn);
			Controls.Add(createbtn);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "MainScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MainScreen";
			Load += MainScreen_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button createbtn;
		private Button updatebtn;
		private Button deletebtn;
		private Button numberOfAppointmentsbtn;
		private Button consultantsSchedulesbtn;
		private Button customerReportsbtn;
		private Button button7;
		private Button button8;
		private Button button9;
		private DataGridView dataGridView1;
		private MonthCalendar monthCalendar1;
		private Label label5;
	}
}