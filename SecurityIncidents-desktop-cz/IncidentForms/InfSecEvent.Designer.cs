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
            Data.Person person2 = new Data.Person();
            persNotifier = new IncidentForms.Components.PersonControl();
            label2 = new Label();
            dateEventDate = new DateTimePicker();
            label3 = new Label();
            txtEventID = new TextBox();
            grpDescription = new GroupBox();
            txtDescription = new TextBox();
            grpDetails = new GroupBox();
            label7 = new Label();
            tsDuration = new IncidentForms.Components.TimeSpanControl();
            chkClosed = new CheckBox();
            dtEventReportDateTime = new DateTimePicker();
            label6 = new Label();
            dtEventDetectionDateTime = new DateTimePicker();
            label5 = new Label();
            dtEventStartDateTime = new DateTimePicker();
            label4 = new Label();
            grpRelated = new GroupBox();
            lstRelated = new IncidentForms.Components.EditableListControl();
            grpAttachment = new GroupBox();
            lstAttachment = new IncidentForms.Components.EditableListControl();
            grpDescription.SuspendLayout();
            grpDetails.SuspendLayout();
            grpRelated.SuspendLayout();
            grpAttachment.SuspendLayout();
            SuspendLayout();
            // 
            // persNotifier
            // 
            persNotifier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            persNotifier.ControlName = "Oznamující osoba";
            persNotifier.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            
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
            persNotifier.LabelPhone = "Telefon";
            persNotifier.Location = new Point(30, 242);
            persNotifier.Margin = new Padding(3, 4, 3, 4);
            persNotifier.Name = "persNotifier";
            person2.Address = "";
            person2.Email = "";
            person2.Name = "";
            person2.Organization = "";
            person2.OrgUnit = "";
            person2.Phone = "";
            persNotifier.PersonData = person2;
            persNotifier.Size = new Size(787, 269);
            persNotifier.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 18);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 2;
            label2.Text = "Datum události";
            // 
            // dateEventDate
            // 
            dateEventDate.Format = DateTimePickerFormat.Short;
            dateEventDate.Location = new Point(166, 13);
            dateEventDate.Margin = new Padding(3, 4, 3, 4);
            dateEventDate.Name = "dateEventDate";
            dateEventDate.Size = new Size(148, 25);
            dateEventDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 18);
            label3.Name = "label3";
            label3.Size = new Size(160, 18);
            label3.TabIndex = 4;
            label3.Text = "Číslo události (ID)";
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(541, 13);
            txtEventID.Margin = new Padding(3, 4, 3, 4);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(276, 25);
            txtEventID.TabIndex = 5;
            // 
            // grpDescription
            // 
            grpDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDescription.Controls.Add(txtDescription);
            grpDescription.Location = new Point(30, 518);
            grpDescription.Margin = new Padding(3, 4, 3, 4);
            grpDescription.Name = "grpDescription";
            grpDescription.Padding = new Padding(3, 4, 3, 4);
            grpDescription.Size = new Size(787, 220);
            grpDescription.TabIndex = 6;
            grpDescription.TabStop = false;
            grpDescription.Text = "Popis události";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(19, 26);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(746, 172);
            txtDescription.TabIndex = 0;
            // 
            // grpDetails
            // 
            grpDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpDetails.Controls.Add(label7);
            grpDetails.Controls.Add(tsDuration);
            grpDetails.Controls.Add(chkClosed);
            grpDetails.Controls.Add(dtEventReportDateTime);
            grpDetails.Controls.Add(label6);
            grpDetails.Controls.Add(dtEventDetectionDateTime);
            grpDetails.Controls.Add(label5);
            grpDetails.Controls.Add(dtEventStartDateTime);
            grpDetails.Controls.Add(label4);
            grpDetails.Location = new Point(30, 745);
            grpDetails.Margin = new Padding(3, 4, 3, 4);
            grpDetails.Name = "grpDetails";
            grpDetails.Padding = new Padding(3, 4, 3, 4);
            grpDetails.Size = new Size(787, 172);
            grpDetails.TabIndex = 7;
            grpDetails.TabStop = false;
            grpDetails.Text = "Podrobnosti o události";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 130);
            label7.Name = "label7";
            label7.Size = new Size(96, 18);
            label7.TabIndex = 8;
            label7.Text = "Doba trvání";
            // 
            // tsDuration
            // 
            tsDuration.DaysLabel = "Dny";
            tsDuration.Duration = TimeSpan.Parse("00:00:00");
            tsDuration.DurationText = "00:00:00";
            tsDuration.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tsDuration.HoursLabel = "Hodiny";
            tsDuration.Location = new Point(155, 96);
            tsDuration.Margin = new Padding(3, 4, 3, 4);
            tsDuration.MinutesLabel = "Minuty";
            tsDuration.Name = "tsDuration";
            tsDuration.Size = new Size(191, 68);
            tsDuration.TabIndex = 7;
            // 
            // chkClosed
            // 
            chkClosed.AutoSize = true;
            chkClosed.Location = new Point(395, 129);
            chkClosed.Margin = new Padding(3, 4, 3, 4);
            chkClosed.Name = "chkClosed";
            chkClosed.Size = new Size(147, 22);
            chkClosed.TabIndex = 6;
            chkClosed.Text = "Odezva uzavřena";
            chkClosed.UseVisualStyleBackColor = true;
            // 
            // dtEventReportDateTime
            // 
            dtEventReportDateTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtEventReportDateTime.Format = DateTimePickerFormat.Custom;
            dtEventReportDateTime.Location = new Point(155, 61);
            dtEventReportDateTime.Margin = new Padding(3, 4, 3, 4);
            dtEventReportDateTime.Name = "dtEventReportDateTime";
            dtEventReportDateTime.ShowUpDown = true;
            dtEventReportDateTime.Size = new Size(174, 25);
            dtEventReportDateTime.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 68);
            label6.Name = "label6";
            label6.Size = new Size(112, 18);
            label6.TabIndex = 4;
            label6.Text = "Podání zprávy";
            // 
            // dtEventDetectionDateTime
            // 
            dtEventDetectionDateTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtEventDetectionDateTime.Format = DateTimePickerFormat.Custom;
            dtEventDetectionDateTime.Location = new Point(547, 26);
            dtEventDetectionDateTime.Margin = new Padding(3, 4, 3, 4);
            dtEventDetectionDateTime.Name = "dtEventDetectionDateTime";
            dtEventDetectionDateTime.ShowUpDown = true;
            dtEventDetectionDateTime.Size = new Size(174, 25);
            dtEventDetectionDateTime.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 31);
            label5.Name = "label5";
            label5.Size = new Size(136, 18);
            label5.TabIndex = 2;
            label5.Text = "Detekce události";
            // 
            // dtEventStartDateTime
            // 
            dtEventStartDateTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtEventStartDateTime.Format = DateTimePickerFormat.Custom;
            dtEventStartDateTime.Location = new Point(155, 26);
            dtEventStartDateTime.Margin = new Padding(3, 4, 3, 4);
            dtEventStartDateTime.Name = "dtEventStartDateTime";
            dtEventStartDateTime.ShowUpDown = true;
            dtEventStartDateTime.Size = new Size(174, 25);
            dtEventStartDateTime.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 34);
            label4.Name = "label4";
            label4.Size = new Size(120, 18);
            label4.TabIndex = 0;
            label4.Text = "Vznik události";
            // 
            // grpRelated
            // 
            grpRelated.Controls.Add(lstRelated);
            grpRelated.Location = new Point(30, 46);
            grpRelated.Margin = new Padding(3, 4, 3, 4);
            grpRelated.Name = "grpRelated";
            grpRelated.Padding = new Padding(3, 4, 3, 4);
            grpRelated.Size = new Size(385, 190);
            grpRelated.TabIndex = 8;
            grpRelated.TabStop = false;
            grpRelated.Text = "Související ID";
            // 
            // lstRelated
            // 
            lstRelated.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstRelated.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lstRelated.Location = new Point(6, 22);
            lstRelated.Margin = new Padding(3, 4, 3, 4);
            lstRelated.Name = "lstRelated";
            lstRelated.Size = new Size(373, 160);
            lstRelated.TabIndex = 0;
            // 
            // grpAttachment
            // 
            grpAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAttachment.Controls.Add(lstAttachment);
            grpAttachment.Location = new Point(432, 46);
            grpAttachment.Margin = new Padding(3, 4, 3, 4);
            grpAttachment.Name = "grpAttachment";
            grpAttachment.Padding = new Padding(3, 4, 3, 4);
            grpAttachment.Size = new Size(385, 190);
            grpAttachment.TabIndex = 9;
            grpAttachment.TabStop = false;
            grpAttachment.Text = "Přílohy";
            // 
            // lstAttachment
            // 
            lstAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstAttachment.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lstAttachment.Location = new Point(6, 23);
            lstAttachment.Margin = new Padding(3, 4, 3, 4);
            lstAttachment.Name = "lstAttachment";
            lstAttachment.Size = new Size(373, 160);
            lstAttachment.TabIndex = 0;
            // 
            // InfSecEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpAttachment);
            Controls.Add(grpRelated);
            Controls.Add(grpDetails);
            Controls.Add(grpDescription);
            Controls.Add(txtEventID);
            Controls.Add(label3);
            Controls.Add(dateEventDate);
            Controls.Add(label2);
            Controls.Add(persNotifier);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InfSecEvent";
            Size = new Size(846, 921);
            grpDescription.ResumeLayout(false);
            grpDescription.PerformLayout();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            grpRelated.ResumeLayout(false);
            grpAttachment.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.PersonControl persNotifier;
        private Label label2;
        private DateTimePicker dateEventDate;
        private Label label3;
        private TextBox txtEventID;
        private GroupBox grpDescription;
        private TextBox txtDescription;
        private GroupBox grpDetails;
        private GroupBox grpRelated;
        private Components.EditableListControl lstRelated;
        private DateTimePicker dtEventStartDateTime;
        private Label label4;
        private DateTimePicker dtEventDetectionDateTime;
        private Label label5;
        private Label label7;
        private Components.TimeSpanControl tsDuration;
        private CheckBox chkClosed;
        private DateTimePicker dtEventReportDateTime;
        private Label label6;
        private GroupBox grpAttachment;
        private Components.EditableListControl lstAttachment;
    }
}
