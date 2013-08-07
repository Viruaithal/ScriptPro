namespace DrawingListUC
{
    partial class Wizard_Step1
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
            this.Viewbutton = new System.Windows.Forms.Button();
            this.ScriptBrowse = new System.Windows.Forms.Button();
            this.ScriptPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Viewbutton
            // 
            this.Viewbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewbutton.BackColor = System.Drawing.SystemColors.Control;
            this.Viewbutton.Location = new System.Drawing.Point(457, 7);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(67, 24);
            this.Viewbutton.TabIndex = 2;
            this.Viewbutton.Text = "Edit";
            this.Viewbutton.UseVisualStyleBackColor = false;
            this.Viewbutton.Click += new System.EventHandler(this.Viewbutton_Click);
            // 
            // ScriptBrowse
            // 
            this.ScriptBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.ScriptBrowse.Location = new System.Drawing.Point(383, 7);
            this.ScriptBrowse.Name = "ScriptBrowse";
            this.ScriptBrowse.Size = new System.Drawing.Size(67, 24);
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
            this.ScriptPath.Location = new System.Drawing.Point(1, 10);
            this.ScriptPath.Margin = new System.Windows.Forms.Padding(0);
            this.ScriptPath.Name = "ScriptPath";
            this.ScriptPath.Size = new System.Drawing.Size(372, 20);
            this.ScriptPath.TabIndex = 0;
            // 
            // Wizard_Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Viewbutton);
            this.Controls.Add(this.ScriptBrowse);
            this.Controls.Add(this.ScriptPath);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Wizard_Step1";
            this.Size = new System.Drawing.Size(528, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Viewbutton;
        private System.Windows.Forms.Button ScriptBrowse;
        private System.Windows.Forms.TextBox ScriptPath;
    }
}
