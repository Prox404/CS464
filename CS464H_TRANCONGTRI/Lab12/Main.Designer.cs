namespace Lab12
{
	partial class Main
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hồSơKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýSinhViênToolStripMenuItem,
            this.thôngTinKhoaToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 27);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
			this.hệThốngToolStripMenuItem.Text = "Hệ thống";
			// 
			// quảnLýSinhViênToolStripMenuItem
			// 
			this.quảnLýSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSinhViênToolStripMenuItem});
			this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
			this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(127, 23);
			this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
			// 
			// danhSáchSinhViênToolStripMenuItem
			// 
			this.danhSáchSinhViênToolStripMenuItem.Name = "danhSáchSinhViênToolStripMenuItem";
			this.danhSáchSinhViênToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.danhSáchSinhViênToolStripMenuItem.Text = "Danh sách sinh viên";
			this.danhSáchSinhViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSinhViênToolStripMenuItem_Click);
			// 
			// thôngTinKhoaToolStripMenuItem
			// 
			this.thôngTinKhoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơKhoaToolStripMenuItem});
			this.thôngTinKhoaToolStripMenuItem.Name = "thôngTinKhoaToolStripMenuItem";
			this.thôngTinKhoaToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
			this.thôngTinKhoaToolStripMenuItem.Text = "Thông tin khoa";
			// 
			// hồSơKhoaToolStripMenuItem
			// 
			this.hồSơKhoaToolStripMenuItem.Name = "hồSơKhoaToolStripMenuItem";
			this.hồSơKhoaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
			this.hồSơKhoaToolStripMenuItem.Text = "Hồ sơ khoa";
			this.hồSơKhoaToolStripMenuItem.Click += new System.EventHandler(this.hồSơKhoaToolStripMenuItem_Click);
			// 
			// giớiThiệuToolStripMenuItem
			// 
			this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
			this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
			this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
			// 
			// giúpĐỡToolStripMenuItem
			// 
			this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
			this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
			this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thôngTinKhoaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hồSơKhoaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
	}
}

