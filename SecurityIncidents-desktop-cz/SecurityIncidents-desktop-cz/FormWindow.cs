using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecurityIncidents_desktop_cz
{
    public partial class FormWindow : Form
    {
        
        public FormWindow()
        {
            InitializeComponent();
        }

        public void SetForm(UserControl form)
        {
            pnlForm.Controls.Clear();
            pnlForm.AutoScroll = true;
            form.Dock = DockStyle.Top;
            pnlForm.Controls.Add(form);

        }
    }
}
