/*
 * 由SharpDevelop创建。
 * 用户： ifwz
 * 日期: 2023/4/28
 * 时间: 20:23
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Nixie
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		[DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private const int VM_NCLBUTTONDOWN = 0XA1;//定义鼠标左键按下
        private const int HTCAPTION = 2;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pictureBox6.Image=Image.FromFile("image/relax.jpg");
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void 退出ToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void 发电ToolStripMenuItemClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://afdian.net/a/ifwz1729");
		}
		void 随机排列5ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Random ran = new Random();
			int a = ran.Next(0, 10);
			int b = ran.Next(0, 10);
			int c = ran.Next(0, 10);
			int d = ran.Next(0, 10);
			int f = ran.Next(0, 10);
			pictureBox1.Image=Image.FromFile("image/"+a+".png");
			pictureBox2.Image=Image.FromFile("image/"+b+".png");
			pictureBox3.Image=Image.FromFile("image/"+c+".png");
			pictureBox4.Image=Image.FromFile("image/"+d+".png");
			pictureBox5.Image=Image.FromFile("image/"+f+".png");
			flag=false;
			flag2=false;
		}
		bool flag=false;
		void 时钟模式ToolStripMenuItemClick(object sender, EventArgs e)
		{
			flag=true;
			flag2=false;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if (flag) {
				string t=DateTime.Now.ToString("t");
				pictureBox1.Image=Image.FromFile("image/"+t[0]+".png");
				pictureBox2.Image=Image.FromFile("image/"+t[1]+".png");
				pictureBox3.Image=Image.FromFile("image/"+"..png");
				pictureBox4.Image=Image.FromFile("image/"+t[3]+".png");
				pictureBox5.Image=Image.FromFile("image/"+t[4]+".png");
			}
		}
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			flag=false;
			flag2=true;
			 
		}
		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
			//为当前应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
		}
		void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{
			//为当前应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
		}
		void PictureBox2MouseDown(object sender, MouseEventArgs e)
		{
			//为当前应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
		}
		void PictureBox3MouseDown(object sender, MouseEventArgs e)
		{
			//为当前应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
		}
		void PictureBox4MouseDown(object sender, MouseEventArgs e)
		{
			//为当前应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
		}
		void PictureBox5MouseDown(object sender, MouseEventArgs e)
		{
			//为当前应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
		}
		bool flag2=false;
		TimeSpan ts = new TimeSpan(0, 20, 0);
		void Timer2Tick(object sender, EventArgs e)
		{
			if (flag2) {
				
				ts = ts.Subtract(new TimeSpan(0, 0, 1));
				string t=ts.ToString("T");
				pictureBox1.Image=Image.FromFile("image/"+t[3]+".png");
				pictureBox2.Image=Image.FromFile("image/"+t[4]+".png");
				pictureBox3.Image=Image.FromFile("image/"+"..png");
				pictureBox4.Image=Image.FromFile("image/"+t[6]+".png");
				pictureBox5.Image=Image.FromFile("image/"+t[7]+".png");
				
				if (ts.TotalSeconds < 1.0) {
					timer2.Enabled = false;
					this.Height=240;
					this.Location = new Point(this.Location.X,this.Location.Y-130);
					pictureBox6.Location=new Point(6,0);
					this.BackColor=Color.White;
					this.Refresh();
					Thread.Sleep(20*1000);
					this.Location = new Point(this.Location.X,this.Location.Y+130);
					pictureBox6.Location=new Point(6,104);
					this.BackColor=Color.Black;
					this.Height=110;
					timer2.Enabled = true;
					ts = new TimeSpan(0, 20, 0);
				}
			}
		}
		 
		 
		
	}
}
