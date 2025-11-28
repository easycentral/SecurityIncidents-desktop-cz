namespace IncidentForms.Components
{
    partial class TimeSpanControl
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
            lblDays = new Label();
            lblHours = new Label();
            lblMinutes = new Label();
            numDays = new NumericUpDown();
            numHours = new NumericUpDown();
            numMinutes = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
            SuspendLayout();
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(0, 4);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(32, 15);
            lblDays.TabIndex = 0;
            lblDays.Text = "Days";
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(57, 4);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(39, 15);
            lblHours.TabIndex = 0;
            lblHours.Text = "Hours";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(114, 4);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(50, 15);
            lblMinutes.TabIndex = 0;
            lblMinutes.Text = "Minutes";
            // 
            // numDays
            // 
            numDays.Location = new Point(0, 26);
            numDays.Name = "numDays";
            numDays.Size = new Size(51, 23);
            numDays.TabIndex = 1;
            // 
            // numHours
            // 
            numHours.Location = new Point(57, 26);
            numHours.Name = "numHours";
            numHours.Size = new Size(51, 23);
            numHours.TabIndex = 1;
            // 
            // numMinutes
            // 
            numMinutes.Location = new Point(114, 26);
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new Size(51, 23);
            numMinutes.TabIndex = 1;
            // 
            // TimeSpanControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numMinutes);
            Controls.Add(numHours);
            Controls.Add(numDays);
            Controls.Add(lblMinutes);
            Controls.Add(lblHours);
            Controls.Add(lblDays);
            Name = "TimeSpanControl";
            Size = new Size(167, 57);
            ((System.ComponentModel.ISupportInitialize)numDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDays;
        private Label lblHours;
        private Label lblMinutes;
        private NumericUpDown numDays;
        private NumericUpDown numHours;
        private NumericUpDown numMinutes;
    }
}
