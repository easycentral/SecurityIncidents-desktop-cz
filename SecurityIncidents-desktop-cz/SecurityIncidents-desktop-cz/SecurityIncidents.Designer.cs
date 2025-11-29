namespace SecurityIncidents_desktop_cz
{
    partial class SecurityIncidents
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
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuForm = new ToolStripMenuItem();
            mnuEventForm = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuForm });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(7, 2, 0, 2);
            mnuMain.Size = new Size(914, 26);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(68, 22);
            mnuFile.Text = "&Soubor";
            // 
            // mnuForm
            // 
            mnuForm.DropDownItems.AddRange(new ToolStripItem[] { mnuEventForm });
            mnuForm.Name = "mnuForm";
            mnuForm.Size = new Size(84, 22);
            mnuForm.Text = "&Formulář";
            // 
            // mnuEventForm
            // 
            mnuEventForm.Name = "mnuEventForm";
            mnuEventForm.Size = new Size(212, 22);
            mnuEventForm.Text = "Zpráva o &události";
            mnuEventForm.Click += mnuEventForm_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 518);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(914, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // SecurityIncidents
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 540);
            Controls.Add(statusStrip1);
            Controls.Add(mnuMain);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SecurityIncidents";
            Text = "SecurityIncidents";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuForm;
        private ToolStripMenuItem mnuEventForm;
        private StatusStrip statusStrip1;
    }
}