namespace Lab5_UIChua
{
	partial class Form1
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
			this.groupBox_TTSV = new System.Windows.Forms.GroupBox();
			this.lb_main = new System.Windows.Forms.Label();
			this.txt_maSV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.groupBox_TTSV.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_TTSV
			// 
			this.groupBox_TTSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_TTSV.Controls.Add(this.dateTimePicker1);
			this.groupBox_TTSV.Controls.Add(this.label4);
			this.groupBox_TTSV.Controls.Add(this.radioButton3);
			this.groupBox_TTSV.Controls.Add(this.radioButton2);
			this.groupBox_TTSV.Controls.Add(this.radioButton1);
			this.groupBox_TTSV.Controls.Add(this.label3);
			this.groupBox_TTSV.Controls.Add(this.label2);
			this.groupBox_TTSV.Controls.Add(this.textBox1);
			this.groupBox_TTSV.Controls.Add(this.label1);
			this.groupBox_TTSV.Controls.Add(this.txt_maSV);
			this.groupBox_TTSV.Location = new System.Drawing.Point(36, 55);
			this.groupBox_TTSV.Name = "groupBox_TTSV";
			this.groupBox_TTSV.Size = new System.Drawing.Size(693, 346);
			this.groupBox_TTSV.TabIndex = 0;
			this.groupBox_TTSV.TabStop = false;
			this.groupBox_TTSV.Text = "Thông Tin Sinh Viên";
			this.groupBox_TTSV.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// lb_main
			// 
			this.lb_main.AutoSize = true;
			this.lb_main.Cursor = System.Windows.Forms.Cursors.PanEast;
			this.lb_main.Location = new System.Drawing.Point(334, 19);
			this.lb_main.Name = "lb_main";
			this.lb_main.Size = new System.Drawing.Size(111, 13);
			this.lb_main.TabIndex = 1;
			this.lb_main.Text = "QUAN LY SINH VIEN";
			this.lb_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb_main.Click += new System.EventHandler(this.label1_Click);
			// 
			// txt_maSV
			// 
			this.txt_maSV.Location = new System.Drawing.Point(119, 37);
			this.txt_maSV.Name = "txt_maSV";
			this.txt_maSV.Size = new System.Drawing.Size(142, 20);
			this.txt_maSV.TabIndex = 2;
			this.txt_maSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã SV:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tên Đầy Đủ:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(119, 73);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 20);
			this.textBox1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Giới Tính:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(119, 111);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 17);
			this.radioButton1.TabIndex = 7;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Nam";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(119, 134);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(39, 17);
			this.radioButton2.TabIndex = 8;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Nữ";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(119, 157);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(50, 17);
			this.radioButton3.TabIndex = 9;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Khác";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Giới Tính:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dateTimePicker1.Location = new System.Drawing.Point(119, 198);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
			this.dateTimePicker1.TabIndex = 11;
			this.dateTimePicker1.Value = new System.DateTime(2023, 3, 17, 22, 24, 14, 0);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lb_main);
			this.Controls.Add(this.groupBox_TTSV);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox_TTSV.ResumeLayout(false);
			this.groupBox_TTSV.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_TTSV;
		private System.Windows.Forms.Label lb_main;
		private System.Windows.Forms.TextBox txt_maSV;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}

