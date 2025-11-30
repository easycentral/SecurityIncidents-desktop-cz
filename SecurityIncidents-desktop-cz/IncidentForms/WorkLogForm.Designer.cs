namespace IncidentForms.Data
{
    partial class WorkLogForm
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
            grpWorkLogItem = new GroupBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtContent = new TextBox();
            label4 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtTimeStamp = new DateTimePicker();
            lstLog = new ListBox();
            btnEdit = new Button();
            btnRemove = new Button();
            lblTabHeader = new Label();
            grpWorkLogItem.SuspendLayout();
            SuspendLayout();
            // 
            // grpWorkLogItem
            // 
            grpWorkLogItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpWorkLogItem.Controls.Add(btnCancel);
            grpWorkLogItem.Controls.Add(btnSave);
            grpWorkLogItem.Controls.Add(txtContent);
            grpWorkLogItem.Controls.Add(label4);
            grpWorkLogItem.Controls.Add(txtTitle);
            grpWorkLogItem.Controls.Add(label3);
            grpWorkLogItem.Controls.Add(txtAuthor);
            grpWorkLogItem.Controls.Add(label2);
            grpWorkLogItem.Controls.Add(label1);
            grpWorkLogItem.Controls.Add(dtTimeStamp);
            grpWorkLogItem.Location = new Point(13, 13);
            grpWorkLogItem.Name = "grpWorkLogItem";
            grpWorkLogItem.Size = new Size(717, 345);
            grpWorkLogItem.TabIndex = 6;
            grpWorkLogItem.TabStop = false;
            grpWorkLogItem.Text = "Záznam";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(555, 308);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 31);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(636, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 31);
            btnSave.TabIndex = 12;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtContent
            // 
            txtContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContent.Location = new Point(6, 121);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(705, 173);
            txtContent.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 8;
            label4.Text = "Detail";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(72, 63);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(639, 25);
            txtTitle.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 66);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 8;
            label3.Text = "Titulek";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(405, 29);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(306, 25);
            txtAuthor.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 32);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 9;
            label2.Text = "Osoba";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 7;
            label1.Text = "Datum a čas";
            // 
            // dtTimeStamp
            // 
            dtTimeStamp.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtTimeStamp.Format = DateTimePickerFormat.Custom;
            dtTimeStamp.Location = new Point(108, 29);
            dtTimeStamp.Margin = new Padding(3, 5, 3, 5);
            dtTimeStamp.Name = "dtTimeStamp";
            dtTimeStamp.ShowUpDown = true;
            dtTimeStamp.Size = new Size(198, 25);
            dtTimeStamp.TabIndex = 6;
            // 
            // lstLog
            // 
            lstLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(13, 431);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(717, 418);
            lstLog.TabIndex = 7;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(649, 376);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 31);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Upravit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.Location = new Point(549, 376);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 31);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Odstranit";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblTabHeader
            // 
            lblTabHeader.AutoSize = true;
            lblTabHeader.Location = new Point(13, 410);
            lblTabHeader.Name = "lblTabHeader";
            lblTabHeader.Size = new Size(80, 18);
            lblTabHeader.TabIndex = 13;
            lblTabHeader.Text = "TabHeader";
            // 
            // WorkLogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTabHeader);
            Controls.Add(btnRemove);
            Controls.Add(lstLog);
            Controls.Add(btnEdit);
            Controls.Add(grpWorkLogItem);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WorkLogForm";
            Size = new Size(744, 864);
            grpWorkLogItem.ResumeLayout(false);
            grpWorkLogItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpWorkLogItem;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtAuthor;
        private Label label2;
        private Label label1;
        private DateTimePicker dtTimeStamp;
        private TextBox txtContent;
        private Label label4;
        private Button btnCancel;
        private Button btnSave;
        private ListBox lstLog;
        private Button btnEdit;
        private Button btnRemove;
        private Label lblTabHeader;
    }
}
