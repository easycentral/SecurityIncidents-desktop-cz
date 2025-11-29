using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncidentForms.Components
{
    public partial class EditableListControl : UserControl
    {
        [Browsable(true)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public List<string> Items
        {
            get
            {
                List<string> items = new List<string>();
                foreach (var item in lstList.Items)
                {
                    items.Add(item.ToString());
                }
                return items;
            }
            set
            {
                lstList.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        lstList.Items.Add(item);
                    }
                }
            }
        }
        public EditableListControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstList.Items.Add(txtItem.Text);
            lstList.SelectedIndex = -1;
            txtItem.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedIndex >= 0)
            {
                lstList.Items.RemoveAt(lstList.SelectedIndex);
                lstList.SelectedIndex = -1;
            }
        }
    }
}
