/*
 * Created by SharpDevelop.
 * User: VaCkensi
 * Date: 18/11/2021
 * Time: 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tp_Formularios
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Form Formulario;
		public MainForm()
		{
			Formulario = new Formulario_1();
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn1Click(object sender, EventArgs e)
		{
			Formulario.Show();
		}
		
		void Btn2Click(object sender, EventArgs e)
		{
			Formulario.Hide();
		}
	}
}
