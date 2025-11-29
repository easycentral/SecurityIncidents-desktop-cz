namespace IncidentForms.Components
{
    partial class PersonControl
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
            ComponentName = new GroupBox();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtOrgUnit = new TextBox();
            lblOrgUnit = new Label();
            txtOrganization = new TextBox();
            lblOrganization = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtName = new TextBox();
            lblName = new Label();
            ComponentName.SuspendLayout();
            SuspendLayout();
            // 
            // ComponentName
            // 
            ComponentName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ComponentName.Controls.Add(txtPhone);
            ComponentName.Controls.Add(lblPhone);
            ComponentName.Controls.Add(txtEmail);
            ComponentName.Controls.Add(lblEmail);
            ComponentName.Controls.Add(txtOrgUnit);
            ComponentName.Controls.Add(lblOrgUnit);
            ComponentName.Controls.Add(txtOrganization);
            ComponentName.Controls.Add(lblOrganization);
            ComponentName.Controls.Add(txtAddress);
            ComponentName.Controls.Add(lblAddress);
            ComponentName.Controls.Add(txtName);
            ComponentName.Controls.Add(lblName);
            ComponentName.Location = new Point(3, 7);
            ComponentName.Margin = new Padding(3, 4, 3, 4);
            ComponentName.Name = "ComponentName";
            ComponentName.Padding = new Padding(3, 4, 3, 4);
            ComponentName.Size = new Size(701, 253);
            ComponentName.TabIndex = 13;
            ComponentName.TabStop = false;
            ComponentName.Text = "Person";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(200, 211);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(494, 25);
            txtPhone.TabIndex = 24;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(16, 215);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(48, 18);
            lblPhone.TabIndex = 23;
            lblPhone.Text = "Phone";
            lblPhone.TextAlign = ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(200, 176);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(494, 25);
            txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(16, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 18);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "E-mail";
            lblEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // txtOrgUnit
            // 
            txtOrgUnit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrgUnit.Location = new Point(200, 142);
            txtOrgUnit.Margin = new Padding(3, 4, 3, 4);
            txtOrgUnit.Name = "txtOrgUnit";
            txtOrgUnit.Size = new Size(494, 25);
            txtOrgUnit.TabIndex = 20;
            // 
            // lblOrgUnit
            // 
            lblOrgUnit.AutoSize = true;
            lblOrgUnit.Location = new Point(16, 145);
            lblOrgUnit.Name = "lblOrgUnit";
            lblOrgUnit.Size = new Size(160, 18);
            lblOrgUnit.TabIndex = 19;
            lblOrgUnit.Text = "Organizational Unit";
            lblOrgUnit.TextAlign = ContentAlignment.TopRight;
            // 
            // txtOrganization
            // 
            txtOrganization.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrganization.Location = new Point(200, 103);
            txtOrganization.Margin = new Padding(3, 4, 3, 4);
            txtOrganization.Name = "txtOrganization";
            txtOrganization.Size = new Size(494, 25);
            txtOrganization.TabIndex = 18;
            // 
            // lblOrganization
            // 
            lblOrganization.AutoSize = true;
            lblOrganization.Location = new Point(16, 107);
            lblOrganization.Name = "lblOrganization";
            lblOrganization.Size = new Size(104, 18);
            lblOrganization.TabIndex = 17;
            lblOrganization.Text = "Organization";
            lblOrganization.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(200, 68);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(494, 25);
            txtAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(16, 72);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(64, 18);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.TopRight;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(200, 34);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(494, 25);
            txtName.TabIndex = 14;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 18);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.TopRight;
            // 
            // PersonControl
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ComponentName);
            Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PersonControl";
            Size = new Size(708, 264);
            ComponentName.ResumeLayout(false);
            ComponentName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ComponentName;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtOrgUnit;
        private Label lblOrgUnit;
        private TextBox txtOrganization;
        private Label lblOrganization;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtName;
        private Label lblName;
    }
}
