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
	public partial class frmFindReplace : Form
	{
		public frmFindReplace(string SelectedText)
		{
			InitializeComponent();
			txtFind.Text = SelectedText;
		}

		private void frmFindReplace_Load(object sender, EventArgs e)
		{

		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			frmMain npp = (frmMain)Owner;
			npp.Find(txtFind.Text);
		}

		private void btnReplace_Click(object sender, EventArgs e)
		{
			frmMain npp = (frmMain)Owner;
			npp.Find(txtFind.Text);
			npp.Replace(txtReplace.Text);
		}

		private void btnReplaceAll_Click(object sender, EventArgs e)
		{
			frmMain npp = (frmMain)Owner;
			npp.pos = 0;
			npp.ReplaceAll(txtFind.Text, txtReplace.Text);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
