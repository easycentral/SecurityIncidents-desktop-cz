using IncidentForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecurityIncidents_desktop_cz
{
    public partial class SecurityIncidents : Form
    {
        
        private List<FormWindow> formWindows { get; set; } = new List<FormWindow>();
        public SecurityIncidents()
        {
            InitializeComponent();
        }

        private void mnuEventForm_Click(object sender, EventArgs e)
        {
            FormWindow frm = new FormWindow { MdiParent = this, Text="Zpráva o události informační bezpečnosti" };
            var EventFrm = new InfSecEvent();
            frm.SetForm(EventFrm);
            frm.Show();
        }
    }
}
