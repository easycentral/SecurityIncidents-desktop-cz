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
        public string ControlName
        {
            get => ComponentName.Text;
            set => ComponentName.Text = value;
        }

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelName
        {
            get => lblName.Text;
            set => lblName.Text=value;
        }
        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelAddress
        {
            get=>lblAddress.Text;
            set=>lblAddress.Text=value;
        }

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelOrganization
        {
            get => lblOrganization.Text;
            set => lblOrganization.Text = value;
        }

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelOrgUnit
        {
            get => lblOrgUnit.Text;
            set => lblOrgUnit.Text = value;
        }

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelEmail
        {
            get => lblEmail.Text;
            set => lblEmail.Text=value;
        }

        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelPhone
        {
            get => lblPhone.Text;
            set => lblPhone.Text=value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public InfSecurityEvent ISEvent { get; set; } = new InfSecurityEvent();

        [Browsable(true)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Person PersonData
        {
            get => new Person
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Organization = txtOrganization.Text,
                OrgUnit = txtOrgUnit.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };
            set
            {
                txtName.Text = value.Name;
                txtAddress.Text = value.Address;
                txtOrganization.Text = value.Organization;
                txtOrgUnit.Text = value.OrgUnit;
                txtEmail.Text = value.Email;
                txtPhone.Text = value.Phone;
            }
        }

        public PersonControl()
        {
            InitializeComponent();

        }
    }
}
