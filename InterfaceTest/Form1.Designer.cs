namespace InterfaceTest
{
    partial class Form1
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
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.lstDtaDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbNames
            // 
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(23, 52);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(218, 28);
            this.cbNames.TabIndex = 0;
            this.cbNames.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
            // 
            // lstDtaDisplay
            // 
            this.lstDtaDisplay.FormattingEnabled = true;
            this.lstDtaDisplay.ItemHeight = 20;
            this.lstDtaDisplay.Location = new System.Drawing.Point(294, 40);
            this.lstDtaDisplay.Name = "lstDtaDisplay";
            this.lstDtaDisplay.Size = new System.Drawing.Size(1696, 884);
            this.lstDtaDisplay.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2197, 977);
            this.Controls.Add(this.lstDtaDisplay);
            this.Controls.Add(this.cbNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.ListBox lstDtaDisplay;
    }
}

