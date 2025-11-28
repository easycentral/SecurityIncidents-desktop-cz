namespace SecurityIncidents_desktop_cz
{
    partial class FormWindow
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
            pnlForm = new Panel();
            SuspendLayout();
            // 
            // pnlForm
            // 
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlForm.Location = new Point(12, 12);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(974, 696);
            pnlForm.TabIndex = 0;
            // 
            // FormWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(998, 720);
            Controls.Add(pnlForm);
            Name = "FormWindow";
            Text = "FormWindow";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForm;
    }
}