using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leson_27_01_2026_Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private Vector2 _lablePos = new(), _speed;
		private bool _isMove = false, _isMoving = false;

		private void UpdateIsMove()
		{
			_isMove = (Math.Abs(_lablePos.X)) > 0 || (Math.Abs(_lablePos.Y)) > 0;

			if (_isMove && !_isMoving)
			{
				Moveing();
				_isMoving = true;
			}
		}

		private async void Moveing()
		{
			while (_isMove)
			{
				await Task.Delay(20);
				label1.Left += (int)(_lablePos.X * (_speed.X + 1));
				label1.Top += (int)(_lablePos.Y *( _speed.Y + 1));

				_speed.X += 0.05f;
				_speed.Y += 0.05f;

				label1.Text = $"speed: x:{_speed.X}, y: {_speed.Y}";

				ChecGameOver();
			}
		}

		private void ChecGameOver()
		{
			if( label1.Location.X <= 0 ||
				label1.Location.Y <= 0 ||
				label1.Location.X > groupBox1.Size.Width ||
				label1.Location.Y > groupBox1.Size.Height)
			{
				Form2 f = new Form2();
				f.ShowDialog();
				this.Close();
			}
		}

		private void rUp_CheckedChanged(object sender, EventArgs e)
		{
			if (_lablePos.X != 0)
				_speed = new();

			_lablePos.X = 0;

			if (bUp.Checked)
				_lablePos.Y = -1;

			UpdateIsMove();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void rDown_CheckedChanged(object sender, EventArgs e)
		{
			if (_lablePos.X != 0)
				_speed = new();
			
			_lablePos.X = 0;

			if (bDown.Checked)
				_lablePos.Y = 1;

			UpdateIsMove();
		}

		private void rLeft_CheckedChanged(object sender, EventArgs e)
		{
			if (_lablePos.Y != 0)
				_speed = new();

			_lablePos.Y = 0;

			if (bLeft.Checked)
				_lablePos.X = -1;

			UpdateIsMove();
		}

		private void rRirht_CheckedChanged(object sender, EventArgs e)
		{
			if (_lablePos.Y != 0)
				_speed = new();

			_lablePos.Y = 0;

			if (bRight.Checked)
				_lablePos.X = 1;

			UpdateIsMove();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
