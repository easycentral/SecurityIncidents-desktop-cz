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
            textBox1 = new TextBox();
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
            ComponentName.Controls.Add(textBox1);
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
            ComponentName.Location = new Point(3, 6);
            ComponentName.Name = "ComponentName";
            ComponentName.Size = new Size(415, 344);
            ComponentName.TabIndex = 13;
            ComponentName.TabStop = false;
            ComponentName.Text = "Person";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(14, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 23);
            textBox1.TabIndex = 24;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(14, 278);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 23;
            lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(14, 247);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(387, 23);
            txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 229);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "E-mail";
            // 
            // txtOrgUnit
            // 
            txtOrgUnit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrgUnit.Location = new Point(14, 197);
            txtOrgUnit.Name = "txtOrgUnit";
            txtOrgUnit.Size = new Size(387, 23);
            txtOrgUnit.TabIndex = 20;
            // 
            // lblOrgUnit
            // 
            lblOrgUnit.AutoSize = true;
            lblOrgUnit.Location = new Point(14, 179);
            lblOrgUnit.Name = "lblOrgUnit";
            lblOrgUnit.Size = new Size(109, 15);
            lblOrgUnit.TabIndex = 19;
            lblOrgUnit.Text = "Organizational Unit";
            // 
            // txtOrganization
            // 
            txtOrganization.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrganization.Location = new Point(14, 146);
            txtOrganization.Name = "txtOrganization";
            txtOrganization.Size = new Size(387, 23);
            txtOrganization.TabIndex = 18;
            // 
            // lblOrganization
            // 
            lblOrganization.AutoSize = true;
            lblOrganization.Location = new Point(14, 128);
            lblOrganization.Name = "lblOrganization";
            lblOrganization.Size = new Size(75, 15);
            lblOrganization.TabIndex = 17;
            lblOrganization.Text = "Organization";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(14, 94);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(387, 23);
            txtAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(14, 76);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Address";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(14, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(387, 23);
            txtName.TabIndex = 14;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(14, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // PersonControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ComponentName);
            Name = "PersonControl";
            Size = new Size(421, 353);
            ComponentName.ResumeLayout(false);
            ComponentName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ComponentName;
        private TextBox textBox1;
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
