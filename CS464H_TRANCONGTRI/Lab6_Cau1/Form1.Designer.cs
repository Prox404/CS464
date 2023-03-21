namespace Lab6_Cau1
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
			this.lib_A = new System.Windows.Forms.ListBox();
			this.lib_B = new System.Windows.Forms.ListBox();
			this.btn_1 = new System.Windows.Forms.Button();
			this.btn_2 = new System.Windows.Forms.Button();
			this.btn_4 = new System.Windows.Forms.Button();
			this.btn_3 = new System.Windows.Forms.Button();
			this.btn_sort = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lib_A
			// 
			this.lib_A.FormattingEnabled = true;
			//this.lib_A.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lib_A.Items.AddRange(new object[] {
            "Trí đẹp trai",
            "Trí sợ ma",
            "Trí sợ vợ",
            "Trí nhà giàu",
            "Trí không nợ môn",
            "Trí không ngu",
            "B",
            "C",
            "D"});
			this.lib_A.Location = new System.Drawing.Point(119, 52);
			this.lib_A.Name = "lib_A";
			this.lib_A.Size = new System.Drawing.Size(200, 303);
			this.lib_A.TabIndex = 0;
			this.lib_A.SelectedIndexChanged += new System.EventHandler(this.lib_A_SelectedIndexChanged);
			// 
			// lib_B
			// 
			this.lib_B.FormattingEnabled = true;
			this.lib_B.Location = new System.Drawing.Point(520, 52);
			this.lib_B.Name = "lib_B";
			this.lib_B.Size = new System.Drawing.Size(200, 303);
			this.lib_B.TabIndex = 1;
			this.lib_B.SelectedIndexChanged += new System.EventHandler(this.lib_B_SelectedIndexChanged);
			// 
			// btn_1
			// 
			this.btn_1.Location = new System.Drawing.Point(371, 210);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(75, 23);
			this.btn_1.TabIndex = 2;
			this.btn_1.Text = ">";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
			// 
			// btn_2
			// 
			this.btn_2.Location = new System.Drawing.Point(371, 239);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new System.Drawing.Size(75, 23);
			this.btn_2.TabIndex = 3;
			this.btn_2.Text = ">>";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
			// 
			// btn_4
			// 
			this.btn_4.Location = new System.Drawing.Point(371, 323);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new System.Drawing.Size(75, 23);
			this.btn_4.TabIndex = 5;
			this.btn_4.Text = "<<";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
			// 
			// btn_3
			// 
			this.btn_3.Location = new System.Drawing.Point(371, 294);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new System.Drawing.Size(75, 23);
			this.btn_3.TabIndex = 4;
			this.btn_3.Text = "<";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
			// 
			// btn_sort
			// 
			this.btn_sort.Location = new System.Drawing.Point(371, 52);
			this.btn_sort.Name = "btn_sort";
			this.btn_sort.Size = new System.Drawing.Size(75, 23);
			this.btn_sort.TabIndex = 6;
			this.btn_sort.Text = "Sap xep";
			this.btn_sort.UseVisualStyleBackColor = true;
			this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_sort);
			this.Controls.Add(this.btn_4);
			this.Controls.Add(this.btn_3);
			this.Controls.Add(this.btn_2);
			this.Controls.Add(this.btn_1);
			this.Controls.Add(this.lib_B);
			this.Controls.Add(this.lib_A);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lib_A;
		private System.Windows.Forms.ListBox lib_B;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_2;
		private System.Windows.Forms.Button btn_4;
		private System.Windows.Forms.Button btn_3;
		private System.Windows.Forms.Button btn_sort;
	}
}

