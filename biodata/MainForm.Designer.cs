/*
 * Created by SharpDevelop.
 * User: User
 * Date: 25/02/2022
 * Time: 9:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace biodata
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(42, 409);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 37);
			this.button1.TabIndex = 0;
			this.button1.Text = "Tampilkan";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(159, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Biodata Mahasiswa USU";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(368, 75);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(319, 292);
			this.listBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Location = new System.Drawing.Point(298, 410);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(102, 36);
			this.button2.TabIndex = 3;
			this.button2.Text = "Hapus";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.button3.Location = new System.Drawing.Point(538, 410);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(103, 36);
			this.button3.TabIndex = 4;
			this.button3.Text = "Keluar";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 29);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nama";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 93);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(226, 22);
			this.textBox1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Umur";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(112, 151);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(226, 22);
			this.textBox2.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Gender";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Laki-Laki",
			"Perempuan"});
			this.comboBox1.Location = new System.Drawing.Point(112, 208);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(226, 24);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 274);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 28);
			this.label5.TabIndex = 11;
			this.label5.Text = "Jurusan";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(112, 274);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(226, 22);
			this.textBox3.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(699, 492);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "biodata";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
