/*
 * Created by SharpDevelop.
 * User: VaCkensi
 * Date: 18/11/2021
 * Time: 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tp_Formularios
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(41, 47);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(191, 70);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "Mostrar";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(41, 149);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(191, 70);
			this.btn2.TabIndex = 1;
			this.btn2.Text = "Ocultar";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Name = "MainForm";
			this.Text = "Tp_Formularios";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
	}
}
