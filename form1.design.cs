namespace LogFormatter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.tabControlFiles = new System.Windows.Forms.TabControl();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.splitMainHorizontal = new System.Windows.Forms.SplitContainer();
            this.splitTopVertical = new System.Windows.Forms.SplitContainer();
            this.mainPopupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitMainHorizontal)).BeginInit();
            this.splitMainHorizontal.Panel1.SuspendLayout();
            this.splitMainHorizontal.Panel2.SuspendLayout();
            this.splitMainHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTopVertical)).BeginInit();
            this.splitTopVertical.Panel1.SuspendLayout();
            this.splitTopVertical.Panel2.SuspendLayout();
            this.splitTopVertical.SuspendLayout();
            this.mainPopupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(133, 9);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 10);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(52, 25);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "💾";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(288, 9);
            this.findButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(56, 25);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // fileListBox
            // 
            this.fileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListBox.Location = new System.Drawing.Point(0, 0);
            this.fileListBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(134, 259);
            this.fileListBox.TabIndex = 0;
            // 
            // tabControlFiles
            // 
            this.tabControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFiles.Location = new System.Drawing.Point(0, 0);
            this.tabControlFiles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControlFiles.Name = "tabControlFiles";
            this.tabControlFiles.SelectedIndex = 0;
            this.tabControlFiles.Size = new System.Drawing.Size(445, 259);
            this.tabControlFiles.TabIndex = 0;
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.Black;
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.ForeColor = System.Drawing.Color.LightGray;
            this.rtbOutput.Location = new System.Drawing.Point(0, 0);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(582, 136);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            this.rtbOutput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RtbOutput_LinkClicked);
            // 
            // splitMainHorizontal
            // 
            this.splitMainHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMainHorizontal.Location = new System.Drawing.Point(9, 49);
            this.splitMainHorizontal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitMainHorizontal.Name = "splitMainHorizontal";
            this.splitMainHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMainHorizontal.Panel1
            // 
            this.splitMainHorizontal.Panel1.Controls.Add(this.splitTopVertical);
            // 
            // splitMainHorizontal.Panel2
            // 
            this.splitMainHorizontal.Panel2.Controls.Add(this.rtbOutput);
            this.splitMainHorizontal.Size = new System.Drawing.Size(582, 398);
            this.splitMainHorizontal.SplitterDistance = 259;
            this.splitMainHorizontal.SplitterWidth = 3;
            this.splitMainHorizontal.TabIndex = 4;
            // 
            // splitTopVertical
            // 
            this.splitTopVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTopVertical.Location = new System.Drawing.Point(0, 0);
            this.splitTopVertical.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitTopVertical.Name = "splitTopVertical";
            // 
            // splitTopVertical.Panel1
            // 
            this.splitTopVertical.Panel1.Controls.Add(this.fileListBox);
            // 
            // splitTopVertical.Panel2
            // 
            this.splitTopVertical.Panel2.Controls.Add(this.tabControlFiles);
            this.splitTopVertical.Size = new System.Drawing.Size(582, 259);
            this.splitTopVertical.SplitterDistance = 134;
            this.splitTopVertical.SplitterWidth = 3;
            this.splitTopVertical.TabIndex = 0;
            // 
            // mainPopupMenu
            // 
            this.mainPopupMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainPopupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFilesMenuItem,
            this.selectFolderMenuItem});
            this.mainPopupMenu.Name = "mainPopupMenu";
            this.mainPopupMenu.Size = new System.Drawing.Size(142, 48);
            // 
            // selectFilesMenuItem
            // 
            this.selectFilesMenuItem.Name = "selectFilesMenuItem";
            this.selectFilesMenuItem.Size = new System.Drawing.Size(141, 22);
            this.selectFilesMenuItem.Text = "Select Files";
            this.selectFilesMenuItem.Click += new System.EventHandler(this.SelectFilesMenuItem_Click);
            // 
            // selectFolderMenuItem
            // 
            this.selectFolderMenuItem.Name = "selectFolderMenuItem";
            this.selectFolderMenuItem.Size = new System.Drawing.Size(141, 22);
            this.selectFolderMenuItem.Text = "Select Folder";
            this.selectFolderMenuItem.Click += new System.EventHandler(this.SelectFolderMenuItem_Click);
            // 
            // openButton
            // 
            this.openButton.ContextMenuStrip = this.mainPopupMenu;
            this.openButton.Location = new System.Drawing.Point(65, 9);
            this.openButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(50, 25);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open ";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 456);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.splitMainHorizontal);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "LogFormatter";
            this.splitMainHorizontal.Panel1.ResumeLayout(false);
            this.splitMainHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMainHorizontal)).EndInit();
            this.splitMainHorizontal.ResumeLayout(false);
            this.splitTopVertical.Panel1.ResumeLayout(false);
            this.splitTopVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTopVertical)).EndInit();
            this.splitTopVertical.ResumeLayout(false);
            this.mainPopupMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.TabControl tabControlFiles;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.SplitContainer splitMainHorizontal;
        private System.Windows.Forms.SplitContainer splitTopVertical;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ContextMenuStrip mainPopupMenu;
        private System.Windows.Forms.ToolStripMenuItem selectFilesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFolderMenuItem;
        private System.Windows.Forms.Button openButton;
    }
}
