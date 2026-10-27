/*
 * Created by SharpDevelop.
 * User: CC2_PC08
 * Date: 26/10/2026
 * Time: 07:33 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_Básicas
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
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
						
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Double Sum = Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text);
			label6.Text=Convert.ToString(Sum);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Double Min = Double.Parse(textBox1.Text) - Double.Parse(textBox2.Text);
			label6.Text=Convert.ToString(Min);			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Double Time = Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text);
			label6.Text=Convert.ToString(Time);			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Double Div = Double.Parse(textBox1.Text) / Double.Parse(textBox2.Text);
			label6.Text=Convert.ToString(Div);			
		}
	}
}
