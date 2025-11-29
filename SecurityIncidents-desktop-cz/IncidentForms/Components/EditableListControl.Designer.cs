namespace IncidentForms.Components
{
    partial class EditableListControl
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
            lstList = new ListBox();
            txtItem = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // lstList
            // 
            lstList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstList.FormattingEnabled = true;
            lstList.Location = new Point(3, 41);
            lstList.Margin = new Padding(3, 4, 3, 4);
            lstList.Name = "lstList";
            lstList.Size = new Size(278, 112);
            lstList.TabIndex = 0;
            // 
            // txtItem
            // 
            txtItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtItem.Location = new Point(3, 6);
            txtItem.Margin = new Padding(3, 4, 3, 4);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(278, 25);
            txtItem.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(289, 4);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.Location = new Point(289, 40);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(98, 28);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // EditableListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtItem);
            Controls.Add(lstList);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditableListControl";
            Size = new Size(391, 160);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstList;
        private TextBox txtItem;
        private Button btnAdd;
        private Button btnRemove;
    }
}
