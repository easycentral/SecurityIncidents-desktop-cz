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
            pnlForm.Location = new Point(14, 14);
            pnlForm.Margin = new Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(1113, 835);
            pnlForm.TabIndex = 0;
            // 
            // FormWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1141, 864);
            Controls.Add(pnlForm);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormWindow";
            Text = "FormWindow";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlForm;
    }
}