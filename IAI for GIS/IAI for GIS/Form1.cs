using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAI_for_GIS
{
	public partial class Form1 : Form
	{
		int jaja = 0;
		Color jeje = Color.FromArgb(255, 0, 255);

		private readonly Random _random = new Random();

		public int RandomNumber(int min, int max)
		{
			return _random.Next(min, max);
		}

		public Form1()
		{
			InitializeComponent();
		}



		public void Form1_Load(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			Graphics graphics = Graphics.FromImage(bitmap as Image);
			graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
			Cursor.Hide();
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			
			textBox1.Text = "X: " + Convert.ToString(e.X);
			textBox3.Text = "Y: " + Convert.ToString(e.Y);

			//pictureBox1.Left = e.X - 3;
			//pictureBox1.Top = e.Y - 2;
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			
			//textBox1.Text = "X: " + Convert.ToString(e.X);
			//textBox3.Text = "Y: " + Convert.ToString(e.Y);

			//pictureBox1.Left = e.X - 5;
			//pictureBox1.Top = e.Y - 5;
			
		}

		private void Form1_Activated(object sender, EventArgs e)
		{

			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			jaja = jaja + 1;
			textBox4.Text = Convert.ToString(pictureBox1.BackColor);

			if(jaja == 1)
			{
				int uno = RandomNumber(0, 255);
				int dos = RandomNumber(0, 255);
				int tres = RandomNumber(0, 255);
				jeje = Color.FromArgb(uno, dos, tres);
				pictureBox1.BackColor = jeje;
			}
			else
			{
				int actualUno = pictureBox1.BackColor.R;
				int actualDos = pictureBox1.BackColor.G;
				int actualTres = pictureBox1.BackColor.B;
				int uno = RandomNumber(actualUno - 20, actualUno + 20);
				int dos = RandomNumber(actualDos - 20, actualDos + 20);
				int tres = RandomNumber(actualTres - 20, actualTres + 20);

				if(uno > 255)
				{
					uno = 255;
				}
				if (uno < 200)
				{
					uno = 200;
				}

				if (dos > 255)
				{
					dos = 255;
				}
				if (dos < 200)
				{
					dos = 200;
				}

				if (tres > 255)
				{
					tres = 255;
				}
				if (tres < 200)
				{
					tres = 200;
				}

				jeje = Color.FromArgb(uno, dos, tres);
				pictureBox1.BackColor = jeje;
			}

			

			

		}

		private void timer2_Tick(object sender, EventArgs e)
		{	
			if(pictureBox1.Visible == true)
			{
				pictureBox1.Visible = false;
			}
			else
			{
				pictureBox1.Visible = true;
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				pictureBox1.Left = pictureBox1.Left - 100;
			}
			if (e.KeyCode == Keys.Right)
			{
				pictureBox1.Left = pictureBox1.Left + 100;
			}

			if (e.KeyCode == Keys.Up)
			{
				pictureBox1.Top = pictureBox1.Top + 100;
			}
			if (e.KeyCode == Keys.Down)
			{
				pictureBox1.Top = pictureBox1.Top - 100;
			}
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				pictureBox1.Left = pictureBox1.Left - 5;
			}
			if (e.KeyCode == Keys.Right)
			{
				pictureBox1.Left = pictureBox1.Left + 5;
			}

			if (e.KeyCode == Keys.Up)
			{
				pictureBox1.Top = pictureBox1.Top - 5;
			}
			if (e.KeyCode == Keys.Down)
			{
				pictureBox1.Top = pictureBox1.Top + 5;
			}
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

	}
}
