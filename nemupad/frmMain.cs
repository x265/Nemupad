using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nemupad
{
	public partial class frmMain : Form
	{
		string _file;
		string _lang;
		string _content;
		UTF8Encoding UTF8 = new UTF8Encoding(false);

		public frmMain(string file, string lang)
		{
			InitializeComponent();
			this.Icon = Properties.Resources.notepad;

			_file = file;
			_lang = lang;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			rtfNotepad.Text = String.IsNullOrEmpty(_file) ? null : File.ReadAllText(_file);
			_content = rtfNotepad.Text;
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!String.Equals(rtfNotepad.Text, _content))
			{
				var msgbox = MessageBox.Show("Do you want to save?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				if (msgbox == DialogResult.Yes)
				{
					using (var sink = new StreamWriter(_file, false, UTF8))
					{
						sink.Write(rtfNotepad.Text);
					}
				}
				else if (msgbox == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
			}
		}

		private void tsmiNew_Click(object sender, EventArgs e)
		{
			if (!String.Equals(rtfNotepad.Text, _content))
			{
				var msgbox = MessageBox.Show("Change detected, save this file?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				if (msgbox == DialogResult.Yes)
				{
					using (var sink = new StreamWriter(_file, false, UTF8))
					{
						sink.Write(rtfNotepad.Text);
					}
				}
				else if (msgbox == DialogResult.No)
				{
					rtfNotepad.Clear();
				}
			}
			else
			{
				rtfNotepad.Clear();
			}
		}

		private void tsmiOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog GetFile = new OpenFileDialog();
			GetFile.Filter = "Supported text files|*.txt;*.avs;*.avsi|"
				+ "Plain Text|*.txt|"
				+ "AviSynth Script|*.avs;*.avsi|"
				+ "All Files|*.*";
			GetFile.FilterIndex = 1;
			GetFile.Multiselect = false;

			if (GetFile.ShowDialog() == DialogResult.OK)
			{
				rtfNotepad.Text = File.ReadAllText(GetFile.FileName);
				_content = rtfNotepad.Text;
			}
		}

		private void tsmiSave_Click(object sender, EventArgs e)
		{
			File.WriteAllText(_file, rtfNotepad.Text, UTF8);
		}

		private void tasmiSaveAs_Click(object sender, EventArgs e)
		{
			SaveFileDialog SaveFile = new SaveFileDialog();
			SaveFile.Filter = "Plain Text|*.txt|"
				+ "AviSynth Script|*.avs;*.avsi|"
				+ "All Files|*.*";
			SaveFile.FilterIndex = 1;

			if (SaveFile.ShowDialog() == DialogResult.OK)
			{
				SaveFile.FileName = "untitled.txt";
				File.WriteAllText(SaveFile.FileName, rtfNotepad.Text, UTF8);
			}
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			this.Close(); // jump to close event
		}

		private void tsmiUndo_Click(object sender, EventArgs e)
		{
			if (rtfNotepad.CanUndo)
				rtfNotepad.Undo();
		}

		private void tsmiCut_Click(object sender, EventArgs e)
		{
			if (rtfNotepad.Text != "")
				rtfNotepad.Cut();
		}

		private void tsmiCopy_Click(object sender, EventArgs e)
		{
			if (rtfNotepad.Text != "")
				rtfNotepad.Copy();
		}

		private void tsmiPaste_Click(object sender, EventArgs e)
		{
			rtfNotepad.Paste();
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			if (rtfNotepad.Text != "")
				rtfNotepad.SelectedText = "";
		}

		private void tsmiFind_Click(object sender, EventArgs e)
		{
			frmFindReplace fr = new frmFindReplace(rtfNotepad.SelectedText);
			fr.Show(this);
		}

		private void tsmiReplace_Click(object sender, EventArgs e)
		{
			frmFindReplace fr = new frmFindReplace(rtfNotepad.SelectedText);
			fr.Show(this);
		}

		private void tsmiSelectAll_Click(object sender, EventArgs e)
		{
			if (rtfNotepad.Text != "")
				rtfNotepad.SelectAll();
		}

		private void tsmiWordWrap_Click(object sender, EventArgs e)
		{
			if (tsmiWordWrap.Checked)
			{
				rtfNotepad.WordWrap = false;
				tsmiWordWrap.Checked = false;
			}
			else
			{
				rtfNotepad.WordWrap = true;
				tsmiWordWrap.Checked = true;
			}
		}

		private void tsmiAbout_Click(object sender, EventArgs e)
		{
			frmAbout frm = new frmAbout();
			frm.ShowDialog();
		}

		#region Find and Replace
		public int pos = 0;

		public void Find(string text)
		{
			try
			{
				this.Focus();
				rtfNotepad.Focus();
				pos = rtfNotepad.Find(text, pos, RichTextBoxFinds.None);
				rtfNotepad.Select(pos, text.Length);
				pos += text.Length;
			}
			catch
			{
				MessageBox.Show("No Occurences Found");
				pos = 0;
			}
		}

		public void Replace(string text)
		{
			if (rtfNotepad.SelectedText.Length != 0)
				rtfNotepad.SelectedText = text;
		}

		public void ReplaceAll(string oldtext, string newtext)
		{
			while (true)
			{
				try
				{
					this.Focus();
					rtfNotepad.Focus();
					pos = rtfNotepad.Find(oldtext, pos, RichTextBoxFinds.None);
					rtfNotepad.Select(pos, oldtext.Length);
					rtfNotepad.SelectedText = newtext;
					pos += oldtext.Length;
				}
				catch
				{
					MessageBox.Show("No Occurences Found");
					pos = 0;
					break;
				}
			}
		}
		#endregion
	}
}
