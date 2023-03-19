namespace Lab5_Cau2
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
			this.lbl_Thu = new System.Windows.Forms.Label();
			this.txt_Thu = new System.Windows.Forms.TextBox();
			this.btn_Tim = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_Thu
			// 
			this.lbl_Thu.AutoSize = true;
			this.lbl_Thu.Location = new System.Drawing.Point(23, 47);
			this.lbl_Thu.Name = "lbl_Thu";
			this.lbl_Thu.Size = new System.Drawing.Size(29, 13);
			this.lbl_Thu.TabIndex = 5;
			this.lbl_Thu.Text = "Thứ:";
			this.lbl_Thu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_Thu
			// 
			this.txt_Thu.Location = new System.Drawing.Point(71, 44);
			this.txt_Thu.Name = "txt_Thu";
			this.txt_Thu.Size = new System.Drawing.Size(187, 20);
			this.txt_Thu.TabIndex = 4;
			// 
			// btn_Tim
			// 
			this.btn_Tim.Location = new System.Drawing.Point(126, 86);
			this.btn_Tim.Name = "btn_Tim";
			this.btn_Tim.Size = new System.Drawing.Size(75, 23);
			this.btn_Tim.TabIndex = 6;
			this.btn_Tim.Text = "Tìm";
			this.btn_Tim.UseVisualStyleBackColor = true;
			this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 146);
			this.Controls.Add(this.btn_Tim);
			this.Controls.Add(this.lbl_Thu);
			this.Controls.Add(this.txt_Thu);
			this.Name = "Form1";
			this.Text = "TimThu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_Thu;
		private System.Windows.Forms.TextBox txt_Thu;
		private System.Windows.Forms.Button btn_Tim;
	}
}

