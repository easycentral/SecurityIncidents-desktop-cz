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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuForm = new ToolStripMenuItem();
            mnuEventForm = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuForm });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(57, 20);
            mnuFile.Text = "&Soubor";
            // 
            // mnuForm
            // 
            mnuForm.DropDownItems.AddRange(new ToolStripItem[] { mnuEventForm });
            mnuForm.Name = "mnuForm";
            mnuForm.Size = new Size(67, 20);
            mnuForm.Text = "&Formulář";
            // 
            // mnuEventForm
            // 
            mnuEventForm.Name = "mnuEventForm";
            mnuEventForm.Size = new Size(180, 22);
            mnuEventForm.Text = "Zpráva o &události";
            mnuEventForm.Click += mnuEventForm_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // SecurityIncidents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "SecurityIncidents";
            Text = "SecurityIncidents";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuForm;
        private ToolStripMenuItem mnuEventForm;
        private StatusStrip statusStrip1;
    }
}