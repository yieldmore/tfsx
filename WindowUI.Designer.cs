namespace Cselian.TfsX
{
	partial class WindowUI
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lvwItems = new System.Windows.Forms.ListView();
			this.btnAttach = new System.Windows.Forms.Button();
			this.stMain = new System.Windows.Forms.StatusStrip();
			this.tsRoot = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsSummary = new System.Windows.Forms.ToolStripStatusLabel();
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colRelPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.stMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvwItems
			// 
			this.lvwItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colRelPath,
            this.colSize,
            this.colModified});
			this.lvwItems.FullRowSelect = true;
			this.lvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvwItems.Location = new System.Drawing.Point(11, 40);
			this.lvwItems.Name = "lvwItems";
			this.lvwItems.Size = new System.Drawing.Size(378, 177);
			this.lvwItems.TabIndex = 0;
			this.lvwItems.UseCompatibleStateImageBehavior = false;
			this.lvwItems.View = System.Windows.Forms.View.Details;
			// 
			// btnAttach
			// 
			this.btnAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAttach.Location = new System.Drawing.Point(314, 11);
			this.btnAttach.Name = "btnAttach";
			this.btnAttach.Size = new System.Drawing.Size(75, 23);
			this.btnAttach.TabIndex = 1;
			this.btnAttach.Text = "Attach";
			this.btnAttach.UseVisualStyleBackColor = true;
			// 
			// stMain
			// 
			this.stMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSummary,
            this.tsRoot});
			this.stMain.Location = new System.Drawing.Point(8, 220);
			this.stMain.Name = "stMain";
			this.stMain.Size = new System.Drawing.Size(384, 22);
			this.stMain.SizingGrip = false;
			this.stMain.TabIndex = 2;
			this.stMain.Text = "statusStrip1";
			// 
			// tsRoot
			// 
			this.tsRoot.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
			this.tsRoot.Name = "tsRoot";
			this.tsRoot.Size = new System.Drawing.Size(311, 17);
			this.tsRoot.Spring = true;
			this.tsRoot.Text = "Root Location:";
			this.tsRoot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tsSummary
			// 
			this.tsSummary.Name = "tsSummary";
			this.tsSummary.Size = new System.Drawing.Size(58, 17);
			this.tsSummary.Text = "Summary";
			// 
			// colName
			// 
			this.colName.Text = "Name";
			// 
			// colRelPath
			// 
			this.colRelPath.Text = "Rel Path";
			this.colRelPath.Width = 128;
			// 
			// colSize
			// 
			this.colSize.Text = "Size";
			// 
			// colModified
			// 
			this.colModified.Text = "Modified";
			this.colModified.Width = 85;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.stMain);
			this.Controls.Add(this.btnAttach);
			this.Controls.Add(this.lvwItems);
			this.MinimumSize = new System.Drawing.Size(400, 250);
			this.Name = "Window";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.Size = new System.Drawing.Size(400, 250);
			this.stMain.ResumeLayout(false);
			this.stMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvwItems;
		private System.Windows.Forms.Button btnAttach;
		private System.Windows.Forms.StatusStrip stMain;
		private System.Windows.Forms.ToolStripStatusLabel tsSummary;
		private System.Windows.Forms.ToolStripStatusLabel tsRoot;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colRelPath;
		private System.Windows.Forms.ColumnHeader colSize;
		private System.Windows.Forms.ColumnHeader colModified;
	}
}
