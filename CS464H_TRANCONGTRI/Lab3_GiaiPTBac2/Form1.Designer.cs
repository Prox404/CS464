namespace Lab3_GiaiPTBac2
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
			this.lbl_HeSoA = new System.Windows.Forms.Label();
			this.txt_HeSoA = new System.Windows.Forms.TextBox();
			this.lbl_HeSoB = new System.Windows.Forms.Label();
			this.txt_HeSoB = new System.Windows.Forms.TextBox();
			this.lbl_HeSoC = new System.Windows.Forms.Label();
			this.txt_HeSoC = new System.Windows.Forms.TextBox();
			this.lbl_KetQua = new System.Windows.Forms.Label();
			this.txt_KetQua = new System.Windows.Forms.TextBox();
			this.btn_Giai = new System.Windows.Forms.Button();
			this.btn_Thoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_HeSoA
			// 
			this.lbl_HeSoA.AutoSize = true;
			this.lbl_HeSoA.Location = new System.Drawing.Point(44, 42);
			this.lbl_HeSoA.Name = "lbl_HeSoA";
			this.lbl_HeSoA.Size = new System.Drawing.Size(48, 13);
			this.lbl_HeSoA.TabIndex = 9;
			this.lbl_HeSoA.Text = "Hệ số A:";
			this.lbl_HeSoA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_HeSoA
			// 
			this.txt_HeSoA.Location = new System.Drawing.Point(126, 42);
			this.txt_HeSoA.Name = "txt_HeSoA";
			this.txt_HeSoA.Size = new System.Drawing.Size(187, 20);
			this.txt_HeSoA.TabIndex = 8;
			this.txt_HeSoA.TextChanged += new System.EventHandler(this.txt_HeSoA_TextChanged);
			// 
			// lbl_HeSoB
			// 
			this.lbl_HeSoB.AutoSize = true;
			this.lbl_HeSoB.Location = new System.Drawing.Point(44, 79);
			this.lbl_HeSoB.Name = "lbl_HeSoB";
			this.lbl_HeSoB.Size = new System.Drawing.Size(48, 13);
			this.lbl_HeSoB.TabIndex = 11;
			this.lbl_HeSoB.Text = "Hệ số B:";
			this.lbl_HeSoB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_HeSoB
			// 
			this.txt_HeSoB.Location = new System.Drawing.Point(126, 79);
			this.txt_HeSoB.Name = "txt_HeSoB";
			this.txt_HeSoB.Size = new System.Drawing.Size(187, 20);
			this.txt_HeSoB.TabIndex = 10;
			// 
			// lbl_HeSoC
			// 
			this.lbl_HeSoC.AutoSize = true;
			this.lbl_HeSoC.Location = new System.Drawing.Point(44, 116);
			this.lbl_HeSoC.Name = "lbl_HeSoC";
			this.lbl_HeSoC.Size = new System.Drawing.Size(48, 13);
			this.lbl_HeSoC.TabIndex = 13;
			this.lbl_HeSoC.Text = "Hệ số C:";
			this.lbl_HeSoC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_HeSoC
			// 
			this.txt_HeSoC.Location = new System.Drawing.Point(126, 116);
			this.txt_HeSoC.Name = "txt_HeSoC";
			this.txt_HeSoC.Size = new System.Drawing.Size(187, 20);
			this.txt_HeSoC.TabIndex = 12;
			// 
			// lbl_KetQua
			// 
			this.lbl_KetQua.AutoSize = true;
			this.lbl_KetQua.Location = new System.Drawing.Point(44, 155);
			this.lbl_KetQua.Name = "lbl_KetQua";
			this.lbl_KetQua.Size = new System.Drawing.Size(47, 13);
			this.lbl_KetQua.TabIndex = 15;
			this.lbl_KetQua.Text = "Ket qua:";
			this.lbl_KetQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_KetQua
			// 
			this.txt_KetQua.Location = new System.Drawing.Point(126, 155);
			this.txt_KetQua.Name = "txt_KetQua";
			this.txt_KetQua.ReadOnly = true;
			this.txt_KetQua.Size = new System.Drawing.Size(187, 20);
			this.txt_KetQua.TabIndex = 14;
			// 
			// btn_Giai
			// 
			this.btn_Giai.Location = new System.Drawing.Point(157, 209);
			this.btn_Giai.Name = "btn_Giai";
			this.btn_Giai.Size = new System.Drawing.Size(75, 23);
			this.btn_Giai.TabIndex = 16;
			this.btn_Giai.Text = "Giai";
			this.btn_Giai.UseVisualStyleBackColor = true;
			this.btn_Giai.Click += new System.EventHandler(this.btn_Giai_Click);
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.Location = new System.Drawing.Point(238, 209);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
			this.btn_Thoat.TabIndex = 17;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.UseVisualStyleBackColor = true;
			this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 244);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_Giai);
			this.Controls.Add(this.lbl_KetQua);
			this.Controls.Add(this.txt_KetQua);
			this.Controls.Add(this.lbl_HeSoC);
			this.Controls.Add(this.txt_HeSoC);
			this.Controls.Add(this.lbl_HeSoB);
			this.Controls.Add(this.txt_HeSoB);
			this.Controls.Add(this.lbl_HeSoA);
			this.Controls.Add(this.txt_HeSoA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_HeSoA;
		private System.Windows.Forms.TextBox txt_HeSoA;
		private System.Windows.Forms.Label lbl_HeSoB;
		private System.Windows.Forms.TextBox txt_HeSoB;
		private System.Windows.Forms.Label lbl_HeSoC;
		private System.Windows.Forms.TextBox txt_HeSoC;
		private System.Windows.Forms.Label lbl_KetQua;
		private System.Windows.Forms.TextBox txt_KetQua;
		private System.Windows.Forms.Button btn_Giai;
		private System.Windows.Forms.Button btn_Thoat;
	}
}

