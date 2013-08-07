namespace DrawingListUC
{
    partial class Wizard_Step2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard_Step2));
            this.Step2_toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.AddFolder = new System.Windows.Forms.ToolStripButton();
            this.RemoveButton = new System.Windows.Forms.ToolStripButton();
            this.Panel_DWGList = new System.Windows.Forms.Panel();
            this.Step2_toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Step2_toolStrip1
            // 
            this.Step2_toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.AddFolder,
            this.RemoveButton});
            this.Step2_toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.Step2_toolStrip1.Name = "Step2_toolStrip1";
            this.Step2_toolStrip1.Size = new System.Drawing.Size(584, 52);
            this.Step2_toolStrip1.TabIndex = 0;
            this.Step2_toolStrip1.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 49);
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddButton.ToolTipText = "Add DWG files";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddFolder
            // 
            this.AddFolder.Image = ((System.Drawing.Image)(resources.GetObject("AddFolder.Image")));
            this.AddFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(86, 49);
            this.AddFolder.Text = "Add from folder";
            this.AddFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddFolder.ToolTipText = "Add from folder";
            this.AddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RemoveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(50, 49);
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Panel_DWGList
            // 
            this.Panel_DWGList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_DWGList.Location = new System.Drawing.Point(3, 58);
            this.Panel_DWGList.Name = "Panel_DWGList";
            this.Panel_DWGList.Size = new System.Drawing.Size(578, 217);
            this.Panel_DWGList.TabIndex = 1;
            // 
            // Wizard_Step2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_DWGList);
            this.Controls.Add(this.Step2_toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Wizard_Step2";
            this.Size = new System.Drawing.Size(584, 278);
            this.Load += new System.EventHandler(this.Wizard_Step2_Load);
            this.Step2_toolStrip1.ResumeLayout(false);
            this.Step2_toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Step2_toolStrip1;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton AddFolder;
        private System.Windows.Forms.ToolStripButton RemoveButton;
        private System.Windows.Forms.Panel Panel_DWGList;
    }
}
