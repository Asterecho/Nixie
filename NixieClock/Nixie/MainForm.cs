/*
 * 由SharpDevelop创建。
 * 用户： ifwz
 * 日期: 2023/5/17
 * 时间: 12:27
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace Nixie
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
			this.WindowState = FormWindowState.Maximized;
			int w=Screen.PrimaryScreen.Bounds.Width;
			int h=Screen.PrimaryScreen.Bounds.Height;
			
			pictureBox1.Image=getimg("1");
			pictureBox1.Location=new Point((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2-(decimal)h/4));
			pictureBox1.Size= new Size((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2));
			
			pictureBox2.Image=getimg("1");
			pictureBox2.Location=new Point((int)Math.Ceiling((decimal)w/10)*2,(int)Math.Ceiling((decimal)h/2-(decimal)h/4));
			pictureBox2.Size= new Size((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2));
			
			pictureBox3.Image=getimg(".");
			pictureBox3.Location=new Point((int)Math.Ceiling((decimal)w/10)*3,(int)Math.Ceiling((decimal)h/2-(decimal)h/4));
			pictureBox3.Size= new Size((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2));
			
			pictureBox4.Image=getimg("4");
			pictureBox4.Location=new Point((int)Math.Ceiling((decimal)w/10)*4,(int)Math.Ceiling((decimal)h/2-(decimal)h/4));
			pictureBox4.Size= new Size((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2));
			
			pictureBox5.Image=getimg("5");
			pictureBox5.Location=new Point((int)Math.Ceiling((decimal)w/10)*5,(int)Math.Ceiling((decimal)h/2-(decimal)h/4));
			pictureBox5.Size= new Size((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2));
			
			pictureBox6.Image=getimg(".");
			pictureBox6.Location=new Point((int)Math.Ceiling((decimal)w/10)*6,(int)Math.Ceiling((decimal)h/2-(decimal)h/4));
			pictureBox6.Size= new Size((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2));
			
			pictureBox7.Image=getimg("1");
			pictureBox7.Location=new Point((int)Math.Ceiling((decimal)w/10)*7,(int)Math.Ceiling((decimal)h/2-(decimal)h/4));
			pictureBox7.Size= new Size((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2));
			
			pictureBox8.Image=getimg("4");
			pictureBox8.Location=new Point((int)Math.Ceiling((decimal)w/10)*8,(int)Math.Ceiling((decimal)h/2-(decimal)h/4));
			pictureBox8.Size= new Size((int)Math.Ceiling((decimal)w/10),(int)Math.Ceiling((decimal)h/2));
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public System.Drawing.Image getimg(string name){
         	Assembly assembly = Assembly.GetExecutingAssembly();
			string resourceName = assembly.GetName().Name.ToString() + "."+name+".png";
			 
			return	System.Drawing.Image.FromStream(assembly.GetManifestResourceStream(resourceName));
         }
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			Environment.Exit(-1);

		}
		void MainFormMouseCaptureChanged(object sender, EventArgs e)
		{
			Environment.Exit(-1);
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			string t=DateTime.Now.ToString("T");
			
			 
			 
			pictureBox1.Image=getimg(t[0].ToString());
			pictureBox2.Image=getimg(t[1].ToString());
			pictureBox4.Image=getimg(t[3].ToString());
			pictureBox5.Image=getimg(t[4].ToString());
			pictureBox7.Image=getimg(t[6].ToString());
			pictureBox8.Image=getimg(t[7].ToString());
		}
	}
}
