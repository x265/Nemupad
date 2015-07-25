namespace nemupad
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rtfNotepad = new System.Windows.Forms.RichTextBox();
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
			this.tasmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReplace = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiWordWrap = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.msMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtfNotepad
			// 
			this.rtfNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtfNotepad.Font = new System.Drawing.Font("Lucida Console", 10F);
			this.rtfNotepad.HideSelection = false;
			this.rtfNotepad.Location = new System.Drawing.Point(0, 24);
			this.rtfNotepad.Name = "rtfNotepad";
			this.rtfNotepad.Size = new System.Drawing.Size(784, 538);
			this.rtfNotepad.TabIndex = 2;
			this.rtfNotepad.Text = "";
			this.rtfNotepad.WordWrap = false;
			// 
			// msMain
			// 
			this.msMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.msMain.Font = new System.Drawing.Font("Tahoma", 8F);
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiView,
            this.tsmiHelp});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(784, 24);
			this.msMain.TabIndex = 3;
			this.msMain.Text = "Main Menu";
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tasmiSaveAs,
            this.tsmiSeparator1,
            this.tsmiExit});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(35, 20);
			this.tsmiFile.Text = "&File";
			// 
			// tsmiNew
			// 
			this.tsmiNew.Name = "tsmiNew";
			this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.tsmiNew.Size = new System.Drawing.Size(140, 22);
			this.tsmiNew.Text = "&New";
			this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
			// 
			// tsmiOpen
			// 
			this.tsmiOpen.Name = "tsmiOpen";
			this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.tsmiOpen.Size = new System.Drawing.Size(140, 22);
			this.tsmiOpen.Text = "&Open";
			this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
			// 
			// tsmiSave
			// 
			this.tsmiSave.Name = "tsmiSave";
			this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.tsmiSave.Size = new System.Drawing.Size(140, 22);
			this.tsmiSave.Text = "&Save";
			this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
			// 
			// tasmiSaveAs
			// 
			this.tasmiSaveAs.Name = "tasmiSaveAs";
			this.tasmiSaveAs.Size = new System.Drawing.Size(140, 22);
			this.tasmiSaveAs.Text = "Save &As";
			this.tasmiSaveAs.Click += new System.EventHandler(this.tasmiSaveAs_Click);
			// 
			// tsmiSeparator1
			// 
			this.tsmiSeparator1.Name = "tsmiSeparator1";
			this.tsmiSeparator1.Size = new System.Drawing.Size(137, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(140, 22);
			this.tsmiExit.Text = "&Exit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// tsmiEdit
			// 
			this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiSeparator2,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete,
            this.tsmiSeparator3,
            this.tsmiFind,
            this.tsmiReplace,
            this.tsmiSeparator4,
            this.tsmiSelectAll});
			this.tsmiEdit.Name = "tsmiEdit";
			this.tsmiEdit.Size = new System.Drawing.Size(37, 20);
			this.tsmiEdit.Text = "&Edit";
			// 
			// tsmiUndo
			// 
			this.tsmiUndo.Name = "tsmiUndo";
			this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.tsmiUndo.Size = new System.Drawing.Size(156, 22);
			this.tsmiUndo.Text = "&Undo";
			this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
			// 
			// tsmiSeparator2
			// 
			this.tsmiSeparator2.Name = "tsmiSeparator2";
			this.tsmiSeparator2.Size = new System.Drawing.Size(153, 6);
			// 
			// tsmiCut
			// 
			this.tsmiCut.Name = "tsmiCut";
			this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.tsmiCut.Size = new System.Drawing.Size(156, 22);
			this.tsmiCut.Text = "&Cut";
			this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
			// 
			// tsmiCopy
			// 
			this.tsmiCopy.Name = "tsmiCopy";
			this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.tsmiCopy.Size = new System.Drawing.Size(156, 22);
			this.tsmiCopy.Text = "C&opy";
			this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
			// 
			// tsmiPaste
			// 
			this.tsmiPaste.Name = "tsmiPaste";
			this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.tsmiPaste.Size = new System.Drawing.Size(156, 22);
			this.tsmiPaste.Text = "&Paste";
			this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.tsmiDelete.Size = new System.Drawing.Size(156, 22);
			this.tsmiDelete.Text = "&Delete";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// tsmiSeparator3
			// 
			this.tsmiSeparator3.Name = "tsmiSeparator3";
			this.tsmiSeparator3.Size = new System.Drawing.Size(153, 6);
			// 
			// tsmiFind
			// 
			this.tsmiFind.Name = "tsmiFind";
			this.tsmiFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.tsmiFind.Size = new System.Drawing.Size(156, 22);
			this.tsmiFind.Text = "&Find";
			this.tsmiFind.Click += new System.EventHandler(this.tsmiFind_Click);
			// 
			// tsmiReplace
			// 
			this.tsmiReplace.Name = "tsmiReplace";
			this.tsmiReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.tsmiReplace.Size = new System.Drawing.Size(156, 22);
			this.tsmiReplace.Text = "&Replace";
			this.tsmiReplace.Click += new System.EventHandler(this.tsmiReplace_Click);
			// 
			// tsmiSeparator4
			// 
			this.tsmiSeparator4.Name = "tsmiSeparator4";
			this.tsmiSeparator4.Size = new System.Drawing.Size(153, 6);
			// 
			// tsmiSelectAll
			// 
			this.tsmiSelectAll.Name = "tsmiSelectAll";
			this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.tsmiSelectAll.Size = new System.Drawing.Size(156, 22);
			this.tsmiSelectAll.Text = "Select &All";
			this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
			// 
			// tsmiView
			// 
			this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWordWrap});
			this.tsmiView.Name = "tsmiView";
			this.tsmiView.Size = new System.Drawing.Size(41, 20);
			this.tsmiView.Text = "&View";
			// 
			// tsmiWordWrap
			// 
			this.tsmiWordWrap.Name = "tsmiWordWrap";
			this.tsmiWordWrap.Size = new System.Drawing.Size(129, 22);
			this.tsmiWordWrap.Text = "&Word Wrap";
			this.tsmiWordWrap.Click += new System.EventHandler(this.tsmiWordWrap_Click);
			// 
			// tsmiHelp
			// 
			this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(40, 20);
			this.tsmiHelp.Text = "&Help";
			// 
			// tsmiAbout
			// 
			this.tsmiAbout.Name = "tsmiAbout";
			this.tsmiAbout.Size = new System.Drawing.Size(103, 22);
			this.tsmiAbout.Text = "&About";
			this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.rtfNotepad);
			this.Controls.Add(this.msMain);
			this.Font = new System.Drawing.Font("Tahoma", 8F);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nemu Pad";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtfNotepad;
		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiSave;
		private System.Windows.Forms.ToolStripSeparator tsmiSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
		private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
		private System.Windows.Forms.ToolStripSeparator tsmiSeparator2;
		private System.Windows.Forms.ToolStripMenuItem tsmiCut;
		private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
		private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.ToolStripSeparator tsmiSeparator3;
		private System.Windows.Forms.ToolStripMenuItem tsmiFind;
		private System.Windows.Forms.ToolStripMenuItem tsmiReplace;
		private System.Windows.Forms.ToolStripSeparator tsmiSeparator4;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
		private System.Windows.Forms.ToolStripMenuItem tsmiView;
		private System.Windows.Forms.ToolStripMenuItem tsmiWordWrap;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
		private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
		private System.Windows.Forms.ToolStripMenuItem tsmiNew;
		private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
		private System.Windows.Forms.ToolStripMenuItem tasmiSaveAs;
	}
}