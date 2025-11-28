using IncidentForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncidentForms.Components
{
    
    
    public partial class PersonControl : UserControl
    {
        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ControlName { get; set; } = "Osoba";

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelName { get; set; } = "Jméno";
        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelAddress { get; set; } = "Adresa";

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelOrganization { get; set; } = "Organizace";

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelOrgUnit { get; set; } = "Útvar";

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelEmail { get; set; } = "E-mail";

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelPhone { get; set; } = "Phone";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public InfSecurityEvent ISEvent {  get; set; }=new InfSecurityEvent();

        public PersonControl()
        {
            InitializeComponent();
            ComponentName.Text= ControlName;
            lblName.Text= LabelName;
            lblAddress.Text= LabelAddress;
            lblOrganization.Text= LabelOrganization;
            lblOrgUnit.Text= LabelOrgUnit;
            lblEmail.Text= LabelEmail;
            lblPhone.Text= LabelPhone;

        }
    }
}
