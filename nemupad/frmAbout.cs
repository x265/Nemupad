using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nemupad
{
	public partial class frmAbout : Form
	{
		public frmAbout()
		{
			InitializeComponent();
			this.Icon = Properties.Resources.notepad;
		}

		private void frmAbout_Load(object sender, EventArgs e)
		{
			this.Opacity = 0;
		}

		private void frmAbout_Shown(object sender, EventArgs e)
		{
			timeFade.Start();
		}

		private void frmAbout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void timeFade_Tick(object sender, EventArgs e)
		{
			if (this.Opacity == 1)
			{
				timeFade.Stop();
			}
			else
			{
				this.Opacity += 0.05;
			}
		}
	}
}
