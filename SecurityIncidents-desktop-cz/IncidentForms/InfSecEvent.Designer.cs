namespace IncidentForms
{
    partial class InfSecEvent
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            Data.InfSecurityEvent infSecurityEvent1 = new Data.InfSecurityEvent();
            Data.Person person1 = new Data.Person();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfSecEvent));
            persNotifier = new IncidentForms.Components.PersonControl();
            label1 = new Label();
            label2 = new Label();
            dateEventDate = new DateTimePicker();
            label3 = new Label();
            txtEventID = new TextBox();
            grpDescription = new GroupBox();
            textBox1 = new TextBox();
            grpDetails = new GroupBox();
            grpDescription.SuspendLayout();
            SuspendLayout();
            // 
            // persNotifier
            // 
            persNotifier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            persNotifier.ControlName = "Oznamující osoba";
            infSecurityEvent1.Comments = "";
            infSecurityEvent1.Description = "";
            infSecurityEvent1.EventDate = new DateTime(2025, 11, 28, 0, 0, 0, 0);
            infSecurityEvent1.EventDetectionDateTime = new DateTime(2025, 11, 28, 18, 6, 37, 520);
            infSecurityEvent1.EventDuration = TimeSpan.Parse("00:00:00");
            infSecurityEvent1.EventID = "";
            infSecurityEvent1.EventReportDateTime = new DateTime(2025, 11, 28, 18, 6, 37, 520);
            infSecurityEvent1.EventStartDateTime = new DateTime(2025, 11, 28, 18, 6, 37, 520);
            person1.Address = "";
            person1.Email = "";
            person1.Name = "";
            person1.Organization = "";
            person1.OrgUnit = "";
            person1.Phone = "";
            infSecurityEvent1.Notifier = person1;
            infSecurityEvent1.RelatedIDs = (List<string>)resources.GetObject("infSecurityEvent1.RelatedIDs");
            infSecurityEvent1.ReportClosed = false;
            persNotifier.ISEvent = infSecurityEvent1;
            persNotifier.LabelAddress = "Adresa";
            persNotifier.LabelEmail = "E-mail";
            persNotifier.LabelName = "Jméno";
            persNotifier.LabelOrganization = "Organizace";
            persNotifier.LabelOrgUnit = "Útvar";
            persNotifier.LabelPhone = "Phone";
            persNotifier.Location = new Point(26, 176);
            persNotifier.Name = "persNotifier";
            persNotifier.Size = new Size(689, 344);
            persNotifier.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(234, 15);
            label1.TabIndex = 1;
            label1.Text = "Zpráva o události informační bezpečnosti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 50);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Datum události";
            // 
            // dateEventDate
            // 
            dateEventDate.Format = DateTimePickerFormat.Short;
            dateEventDate.Location = new Point(130, 44);
            dateEventDate.Name = "dateEventDate";
            dateEventDate.Size = new Size(130, 23);
            dateEventDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 47);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 4;
            label3.Text = "Číslo události (ID)";
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(448, 44);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(267, 23);
            txtEventID.TabIndex = 5;
            // 
            // grpDescription
            // 
            grpDescription.Controls.Add(textBox1);
            grpDescription.Location = new Point(26, 526);
            grpDescription.Name = "grpDescription";
            grpDescription.Size = new Size(689, 183);
            grpDescription.TabIndex = 6;
            grpDescription.TabStop = false;
            grpDescription.Text = "Popis události";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(653, 144);
            textBox1.TabIndex = 0;
            // 
            // grpDetails
            // 
            grpDetails.Location = new Point(26, 715);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(689, 164);
            grpDetails.TabIndex = 7;
            grpDetails.TabStop = false;
            grpDetails.Text = "Podrobnosti o události";
            // 
            // InfSecEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpDetails);
            Controls.Add(grpDescription);
            Controls.Add(txtEventID);
            Controls.Add(label3);
            Controls.Add(dateEventDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(persNotifier);
            Name = "InfSecEvent";
            Size = new Size(740, 888);
            grpDescription.ResumeLayout(false);
            grpDescription.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.PersonControl persNotifier;
        private Label label1;
        private Label label2;
        private DateTimePicker dateEventDate;
        private Label label3;
        private TextBox txtEventID;
        private GroupBox grpDescription;
        private TextBox textBox1;
        private GroupBox grpDetails;
    }
}
