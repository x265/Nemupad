namespace nemupad
{
	partial class frmFindReplace
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnReplaceAll = new System.Windows.Forms.Button();
			this.btnReplace = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.txtReplace = new System.Windows.Forms.TextBox();
			this.lblReplace = new System.Windows.Forms.Label();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.lblFind = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(341, 66);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnReplaceAll
			// 
			this.btnReplaceAll.Location = new System.Drawing.Point(260, 66);
			this.btnReplaceAll.Name = "btnReplaceAll";
			this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
			this.btnReplaceAll.TabIndex = 14;
			this.btnReplaceAll.Text = "Replace &All";
			this.btnReplaceAll.UseVisualStyleBackColor = true;
			this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
			// 
			// btnReplace
			// 
			this.btnReplace.Location = new System.Drawing.Point(179, 66);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.Size = new System.Drawing.Size(75, 23);
			this.btnReplace.TabIndex = 13;
			this.btnReplace.Text = "&Replace";
			this.btnReplace.UseVisualStyleBackColor = true;
			this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(98, 66);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(75, 23);
			this.btnFind.TabIndex = 12;
			this.btnFind.Text = "Find &Next";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtReplace
			// 
			this.txtReplace.Location = new System.Drawing.Point(98, 39);
			this.txtReplace.Name = "txtReplace";
			this.txtReplace.Size = new System.Drawing.Size(318, 21);
			this.txtReplace.TabIndex = 11;
			// 
			// lblReplace
			// 
			this.lblReplace.Location = new System.Drawing.Point(12, 39);
			this.lblReplace.Name = "lblReplace";
			this.lblReplace.Size = new System.Drawing.Size(80, 21);
			this.lblReplace.TabIndex = 10;
			this.lblReplace.Text = "&Replace:";
			this.lblReplace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtFind
			// 
			this.txtFind.Location = new System.Drawing.Point(98, 12);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(318, 21);
			this.txtFind.TabIndex = 9;
			// 
			// lblFind
			// 
			this.lblFind.Location = new System.Drawing.Point(12, 12);
			this.lblFind.Name = "lblFind";
			this.lblFind.Size = new System.Drawing.Size(80, 21);
			this.lblFind.TabIndex = 8;
			this.lblFind.Text = "&Find what:";
			this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmFindReplace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(428, 101);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnReplaceAll);
			this.Controls.Add(this.btnReplace);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.txtReplace);
			this.Controls.Add(this.lblReplace);
			this.Controls.Add(this.txtFind);
			this.Controls.Add(this.lblFind);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximumSize = new System.Drawing.Size(444, 139);
			this.MinimumSize = new System.Drawing.Size(444, 139);
			this.Name = "frmFindReplace";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Find & Replace";
			this.Load += new System.EventHandler(this.frmFindReplace_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnReplaceAll;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox txtReplace;
		private System.Windows.Forms.Label lblReplace;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Label lblFind;
	}
}