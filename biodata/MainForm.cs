/*
 * Created by SharpDevelop.
 * User: User
 * Date: 25/02/2022
 * Time: 9:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace biodata
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Add("Nama    : "+textBox1.Text);
			listBox1.Items.Add("Umur    : "+textBox2.Text+"Tahun");
			listBox1.Items.Add("Gender  : "+comboBox1.SelectedItem);
			listBox1.Items.Add("Jurusan : "+textBox3.Text);
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			DialogResult keluar = MessageBox.Show("Yakin Ingin Keluar?","peringatan",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
			if(keluar == DialogResult.Yes){
				Close();
			}else{
				
				textBox1.Text="";
				textBox2.Text="";
				comboBox1.Text="";
				textBox3.Text="";
				listBox1.Items.Clear();
			}
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text="";
			textBox2.Text="";
			comboBox1.Text="";
			textBox3.Text="";
			listBox1.Items.Clear();
	
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
	}
}
