namespace DrawingListUC
{
    partial class DrawingListControl
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
            this.components = new System.ComponentModel.Container();
            this.DwgList = new System.Windows.Forms.ListView();
            this.dwgName = new System.Windows.Forms.ColumnHeader();
            this.DwgPath = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.DwgContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddDWG = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextDWGAddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextDWGAddFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveDWG = new System.Windows.Forms.ToolStripMenuItem();
            this.SkipDWG = new System.Windows.Forms.ToolStripMenuItem();
            this.chToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadDWGListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDWGListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.failToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BPbar = new System.Windows.Forms.ProgressBar();
            this.scriptGBox = new System.Windows.Forms.GroupBox();
            this.Viewbutton = new System.Windows.Forms.Button();
            this.ScriptBrowse = new System.Windows.Forms.Button();
            this.ScriptPath = new System.Windows.Forms.TextBox();
            this.label_filename = new System.Windows.Forms.Label();
            this.DwgContextMenu.SuspendLayout();
            this.scriptGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DwgList
            // 
            this.DwgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DwgList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DwgList.CheckBoxes = true;
            this.DwgList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dwgName,
            this.DwgPath,
            this.Status});
            this.DwgList.ContextMenuStrip = this.DwgContextMenu;
            this.DwgList.FullRowSelect = true;
            this.DwgList.GridLines = true;
            this.DwgList.Location = new System.Drawing.Point(20, 63);
            this.DwgList.Name = "DwgList";
            this.DwgList.Size = new System.Drawing.Size(582, 142);
            this.DwgList.TabIndex = 3;
            this.DwgList.UseCompatibleStateImageBehavior = false;
            this.DwgList.View = System.Windows.Forms.View.Details;
            this.DwgList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.DwgList_ItemChecked);
            this.DwgList.SizeChanged += new System.EventHandler(this.DwgList_SizeChanged);
            // 
            // dwgName
            // 
            this.dwgName.Text = "Name";
            this.dwgName.Width = 149;
            // 
            // DwgPath
            // 
            this.DwgPath.Text = "Path";
            this.DwgPath.Width = 311;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 61;
            // 
            // DwgContextMenu
            // 
            this.DwgContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDWG,
            this.RemoveDWG,
            this.SkipDWG,
            this.chToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadDWGListToolStripMenuItem,
            this.saveDWGListToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripMenuItem1});
            this.DwgContextMenu.Name = "DwgContextMenu";
            this.DwgContextMenu.Size = new System.Drawing.Size(161, 170);
            this.DwgContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.DwgContextMenu_Opening);
            // 
            // AddDWG
            // 
            this.AddDWG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextDWGAddFile,
            this.ContextDWGAddFolder});
            this.AddDWG.Name = "AddDWG";
            this.AddDWG.Size = new System.Drawing.Size(160, 22);
            this.AddDWG.Text = "Add";
            // 
            // ContextDWGAddFile
            // 
            this.ContextDWGAddFile.Name = "ContextDWGAddFile";
            this.ContextDWGAddFile.Size = new System.Drawing.Size(104, 22);
            this.ContextDWGAddFile.Text = "Files";
            this.ContextDWGAddFile.Click += new System.EventHandler(this.ContextDWGAddFile_Click);
            // 
            // ContextDWGAddFolder
            // 
            this.ContextDWGAddFolder.Name = "ContextDWGAddFolder";
            this.ContextDWGAddFolder.Size = new System.Drawing.Size(104, 22);
            this.ContextDWGAddFolder.Text = "Folder";
            this.ContextDWGAddFolder.Click += new System.EventHandler(this.ContextDWGAddFolder_Click);
            // 
            // RemoveDWG
            // 
            this.RemoveDWG.Name = "RemoveDWG";
            this.RemoveDWG.Size = new System.Drawing.Size(160, 22);
            this.RemoveDWG.Text = "Remove";
            this.RemoveDWG.Click += new System.EventHandler(this.RemoveDWG_Click);
            // 
            // SkipDWG
            // 
            this.SkipDWG.Name = "SkipDWG";
            this.SkipDWG.Size = new System.Drawing.Size(160, 22);
            this.SkipDWG.Text = "Skip";
            this.SkipDWG.Click += new System.EventHandler(this.SkipDWG_Click);
            // 
            // chToolStripMenuItem
            // 
            this.chToolStripMenuItem.Name = "chToolStripMenuItem";
            this.chToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.chToolStripMenuItem.Text = "Check\\Uncheck all";
            this.chToolStripMenuItem.Click += new System.EventHandler(this.chToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // loadDWGListToolStripMenuItem
            // 
            this.loadDWGListToolStripMenuItem.Name = "loadDWGListToolStripMenuItem";
            this.loadDWGListToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loadDWGListToolStripMenuItem.Text = "&Load DWG list";
            this.loadDWGListToolStripMenuItem.Click += new System.EventHandler(this.loadDWGListToolStripMenuItem_Click);
            // 
            // saveDWGListToolStripMenuItem
            // 
            this.saveDWGListToolStripMenuItem.Name = "saveDWGListToolStripMenuItem";
            this.saveDWGListToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveDWGListToolStripMenuItem.Text = "&Save DWG list";
            this.saveDWGListToolStripMenuItem.Click += new System.EventHandler(this.saveDWGListToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.failToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "&Run";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem2.Text = "&Checked";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem3.Text = "&Selected";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // failToolStripMenuItem
            // 
            this.failToolStripMenuItem.Name = "failToolStripMenuItem";
            this.failToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.failToolStripMenuItem.Text = "Failed";
            this.failToolStripMenuItem.Click += new System.EventHandler(this.failToolStripMenuItem_Click);
            // 
            // BPbar
            // 
            this.BPbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BPbar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BPbar.Location = new System.Drawing.Point(125, 211);
            this.BPbar.Name = "BPbar";
            this.BPbar.Size = new System.Drawing.Size(477, 21);
            this.BPbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BPbar.TabIndex = 4;
            // 
            // scriptGBox
            // 
            this.scriptGBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptGBox.Controls.Add(this.Viewbutton);
            this.scriptGBox.Controls.Add(this.ScriptBrowse);
            this.scriptGBox.Controls.Add(this.ScriptPath);
            this.scriptGBox.Location = new System.Drawing.Point(20, 6);
            this.scriptGBox.Name = "scriptGBox";
            this.scriptGBox.Size = new System.Drawing.Size(580, 51);
            this.scriptGBox.TabIndex = 9;
            this.scriptGBox.TabStop = false;
            this.scriptGBox.Text = "Script file";
            // 
            // Viewbutton
            // 
            this.Viewbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewbutton.BackColor = System.Drawing.SystemColors.Control;
            this.Viewbutton.Location = new System.Drawing.Point(502, 15);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(70, 24);
            this.Viewbutton.TabIndex = 2;
            this.Viewbutton.Text = "Edit";
            this.Viewbutton.UseVisualStyleBackColor = false;
            this.Viewbutton.Click += new System.EventHandler(this.Viewbutton_Click);
            // 
            // ScriptBrowse
            // 
            this.ScriptBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.ScriptBrowse.Location = new System.Drawing.Point(409, 16);
            this.ScriptBrowse.Name = "ScriptBrowse";
            this.ScriptBrowse.Size = new System.Drawing.Size(70, 24);
            this.ScriptBrowse.TabIndex = 1;
            this.ScriptBrowse.Text = "Browse";
            this.ScriptBrowse.UseVisualStyleBackColor = false;
            this.ScriptBrowse.Click += new System.EventHandler(this.ScriptBrowse_Click);
            // 
            // ScriptPath
            // 
            this.ScriptPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptPath.Location = new System.Drawing.Point(14, 19);
            this.ScriptPath.Name = "ScriptPath";
            this.ScriptPath.Size = new System.Drawing.Size(359, 20);
            this.ScriptPath.TabIndex = 0;
            // 
            // label_filename
            // 
            this.label_filename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filename.ForeColor = System.Drawing.Color.DarkRed;
            this.label_filename.Location = new System.Drawing.Point(20, 211);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(99, 21);
            this.label_filename.TabIndex = 10;
            this.label_filename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawingListControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.label_filename);
            this.Controls.Add(this.scriptGBox);
            this.Controls.Add(this.DwgList);
            this.Controls.Add(this.BPbar);
            this.Name = "DrawingListControl";
            this.Size = new System.Drawing.Size(636, 247);
            this.Load += new System.EventHandler(this.DrawingListControl_Load);
            this.DwgContextMenu.ResumeLayout(false);
            this.scriptGBox.ResumeLayout(false);
            this.scriptGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DwgList;
        private System.Windows.Forms.ColumnHeader dwgName;
        private System.Windows.Forms.ColumnHeader DwgPath;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ProgressBar BPbar;
        private System.Windows.Forms.ContextMenuStrip DwgContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddDWG;
        private System.Windows.Forms.ToolStripMenuItem ContextDWGAddFile;
        private System.Windows.Forms.ToolStripMenuItem ContextDWGAddFolder;
        private System.Windows.Forms.ToolStripMenuItem RemoveDWG;
        private System.Windows.Forms.ToolStripMenuItem SkipDWG;
        private System.Windows.Forms.ToolStripMenuItem chToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem loadDWGListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDWGListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem failToolStripMenuItem;
        private System.Windows.Forms.GroupBox scriptGBox;
        private System.Windows.Forms.Button Viewbutton;
        private System.Windows.Forms.Button ScriptBrowse;
        private System.Windows.Forms.TextBox ScriptPath;
        private System.Windows.Forms.Label label_filename;
    }
}
