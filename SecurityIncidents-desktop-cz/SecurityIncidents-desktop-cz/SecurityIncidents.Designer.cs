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
            mnuFileNew = new ToolStripMenuItem();
            mnuFileNewEvent = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            mnuFileSave = new ToolStripMenuItem();
            mnuFileSaveAs = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(914, 26);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileSave, mnuFileSaveAs });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(68, 22);
            mnuFile.Text = "&Soubor";
            // 
            // mnuFileNew
            // 
            mnuFileNew.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNewEvent });
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.Size = new Size(196, 22);
            mnuFileNew.Text = "&Nový";
            // 
            // mnuFileNewEvent
            // 
            mnuFileNewEvent.Name = "mnuFileNewEvent";
            mnuFileNewEvent.Size = new Size(132, 22);
            mnuFileNewEvent.Text = "Událost";
            mnuFileNewEvent.Click += mnuFileNewEvent_Click;
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(196, 22);
            mnuFileOpen.Text = "Otevřít ...";
            mnuFileOpen.Click += mnuFileOpen_Click;
            // 
            // mnuFileSave
            // 
            mnuFileSave.Name = "mnuFileSave";
            mnuFileSave.Size = new Size(196, 22);
            mnuFileSave.Text = "Uložit";
            mnuFileSave.Click += mnuFileSave_Click;
            // 
            // mnuFileSaveAs
            // 
            mnuFileSaveAs.Name = "mnuFileSaveAs";
            mnuFileSaveAs.Size = new Size(196, 22);
            mnuFileSaveAs.Text = "Uložit jako ...";
            mnuFileSaveAs.Click += mnuFileSaveAs_Click;
            // 
            // SecurityIncidents
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 540);
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
        private StatusStrip statusStrip1;
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileNewEvent;
        private ToolStripMenuItem mnuFileSave;
        private ToolStripMenuItem mnuFileSaveAs;
    }
}