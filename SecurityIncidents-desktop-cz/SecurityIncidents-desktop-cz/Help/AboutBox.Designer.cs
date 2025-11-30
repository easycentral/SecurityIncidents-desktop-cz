namespace SecurityIncidents_desktop_cz.Help
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            lblVersion = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            lnkSource = new LinkLabel();
            label4 = new Label();
            label6 = new Label();
            lnkGPL = new LinkLabel();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(34, 37);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(56, 18);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Verze:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(22, 9);
            label2.Name = "label2";
            label2.Size = new Size(246, 28);
            label2.TabIndex = 3;
            label2.Text = "Security incidents";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 66);
            label3.Name = "label3";
            label3.Size = new Size(488, 36);
            label3.TabIndex = 4;
            label3.Text = "Aplikace po podporu agendy zvládání bezpečnostních incidentů\r\nJednouživatelská desktopová verze";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 117);
            label5.Name = "label5";
            label5.Size = new Size(648, 126);
            label5.TabIndex = 6;
            label5.Text = resources.GetString("label5.Text");
            // 
            // lnkSource
            // 
            lnkSource.AutoSize = true;
            lnkSource.Location = new Point(224, 277);
            lnkSource.Name = "lnkSource";
            lnkSource.Size = new Size(480, 18);
            lnkSource.TabIndex = 7;
            lnkSource.TabStop = true;
            lnkSource.Text = "https://github.com/easycentral/SecurityIncidents-desktop-cz";
            lnkSource.LinkClicked += lnkSource_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 277);
            label4.Name = "label4";
            label4.Size = new Size(112, 18);
            label4.TabIndex = 8;
            label4.Text = "Zdrojový kód:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 295);
            label6.Name = "label6";
            label6.Size = new Size(184, 18);
            label6.TabIndex = 8;
            label6.Text = "Podrobnosti o licenci:";
            // 
            // lnkGPL
            // 
            lnkGPL.AutoSize = true;
            lnkGPL.Location = new Point(224, 295);
            lnkGPL.Name = "lnkGPL";
            lnkGPL.Size = new Size(336, 18);
            lnkGPL.TabIndex = 7;
            lnkGPL.TabStop = true;
            lnkGPL.Text = "https://www.gnu.org/licenses/gpl-3.0.html";
            lnkGPL.LinkClicked += lnkGPL_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(636, 332);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 30);
            btnClose.TabIndex = 9;
            btnClose.Text = "Zavřít";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AboutBox
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 374);
            Controls.Add(btnClose);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lnkGPL);
            Controls.Add(lnkSource);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblVersion);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AboutBox";
            Text = "O aplikaci";
            Load += AboutBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVersion;
        private Label label2;
        private Label label3;
        private Label label5;
        private LinkLabel lnkSource;
        private Label label4;
        private Label label6;
        private LinkLabel lnkGPL;
        private Button btnClose;
    }
}