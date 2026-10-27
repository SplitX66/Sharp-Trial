/*
 * Created by SharpDevelop.
 * User: CC2_PC08
 * Date: 27/10/2026
 * Time: 07:40 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_Básicas
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text), c = Convert.ToDouble(textBox3.Text);
			double Root = Math.Sqrt(Math.Pow(b,2) - 4*a*c);
			double x1 = (-b + Root) / 2*a;
			double x2 = (-b - Root) / 2*a;
			label6.Text=Convert.ToString(x1);
			label7.Text=Convert.ToString(x2);			
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
	}
}
