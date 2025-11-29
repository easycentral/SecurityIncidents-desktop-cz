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
            mnuFileExport = new ToolStripMenuItem();
            mnuFileExportMarkdown = new ToolStripMenuItem();
            mnuOptions = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuHelpAbout = new ToolStripMenuItem();
            konecToolStripMenuItem = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuOptions, mnuHelp });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(914, 26);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileSave, mnuFileSaveAs, mnuFileExport, konecToolStripMenuItem });
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
            mnuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuFileOpen.Size = new Size(220, 22);
            mnuFileOpen.Text = "&Otevřít ...";
            mnuFileOpen.Click += mnuFileOpen_Click;
            // 
            // mnuFileSave
            // 
            mnuFileSave.Name = "mnuFileSave";
            mnuFileSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuFileSave.Size = new Size(220, 22);
            mnuFileSave.Text = "&Uložit";
            mnuFileSave.Click += mnuFileSave_Click;
            // 
            // mnuFileSaveAs
            // 
            mnuFileSaveAs.Name = "mnuFileSaveAs";
            mnuFileSaveAs.Size = new Size(220, 22);
            mnuFileSaveAs.Text = "Uložit &jako ...";
            mnuFileSaveAs.Click += mnuFileSaveAs_Click;
            // 
            // mnuFileExport
            // 
            mnuFileExport.DropDownItems.AddRange(new ToolStripItem[] { mnuFileExportMarkdown });
            mnuFileExport.Name = "mnuFileExport";
            mnuFileExport.Size = new Size(220, 22);
            mnuFileExport.Text = "&Export";
            // 
            // mnuFileExportMarkdown
            // 
            mnuFileExportMarkdown.Name = "mnuFileExportMarkdown";
            mnuFileExportMarkdown.Size = new Size(180, 22);
            mnuFileExportMarkdown.Text = "&MarkDown";
            mnuFileExportMarkdown.Click += mnuFileExportMarkdown_Click;
            // 
            // mnuOptions
            // 
            mnuOptions.Name = "mnuOptions";
            mnuOptions.Size = new Size(84, 22);
            mnuOptions.Text = "&Možnosti";
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuHelpAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(84, 22);
            mnuHelp.Text = "&Nápověda";
            // 
            // mnuHelpAbout
            // 
            mnuHelpAbout.Name = "mnuHelpAbout";
            mnuHelpAbout.Size = new Size(180, 22);
            mnuHelpAbout.Text = "&O aplikaci";
            // 
            // konecToolStripMenuItem
            // 
            konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            konecToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.X;
            konecToolStripMenuItem.Size = new Size(220, 22);
            konecToolStripMenuItem.Text = "&Konec";
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
        private ToolStripMenuItem mnuFileExport;
        private ToolStripMenuItem mnuFileExportMarkdown;
        private ToolStripMenuItem konecToolStripMenuItem;
        private ToolStripMenuItem mnuOptions;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuHelpAbout;
    }
}