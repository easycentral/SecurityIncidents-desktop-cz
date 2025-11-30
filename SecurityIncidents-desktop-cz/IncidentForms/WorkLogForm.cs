using IncidentForms.Components;
using IncidentForms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncidentForms.Data
{
    public partial class WorkLogForm : FormControl
    {
        [Browsable(false)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string FormType
        {
            get
            {
                return "WorkLog";
            }
        }

        [Browsable(false)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string FormTitle
        {
            get
            {
                return "Záznam činnosti";
            }
        }

        private WorkLog _formData { get; set; } = new WorkLog();
        private bool isEditMode { get; set; } = false;

        private List<ColumnDefinition> columns { get; set; }

        [Browsable(false)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public override IReport? FormData
        {
            get
            {
                return _formData;
            }
            set
            {
                if (value is WorkLog data)
                {
                    _formData = data;
                    RefreshLogList();

                    // zde nastavte hodnoty ovládacích prvků podle dat ve formátu
                }
            }
        }

        private void RefreshLogList()
        {
            lstLog.Items.Clear();
            foreach (var item in _formData.Items)
            {
                lstLog.Items.Add(StringFormatter.ToTableString(item, columns));
            }
        }

        public WorkLogForm()
        {
            InitializeComponent();
            columns = new();
            columns.Add(new("TimeStamp", 20, "Datum a čas"));
            columns.Add(new("Title", 80, "Název"));
            lblTabHeader.Text = StringFormatter.GetHeaderString(columns);
        }
        private void ClearInputFields()
        {
            dtTimeStamp.Value = DateTime.Now;
            txtTitle.Text = "";
            txtContent.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                var selectedIndex = lstLog.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < _formData.Items.Count)
                {
                    var item = _formData.Items[selectedIndex];
                    item.TimeStamp = dtTimeStamp.Value;
                    item.Title = txtTitle.Text;
                    item.Content = txtContent.Text;
                    item.Author = txtAuthor.Text;
                    RefreshLogList();
                    ClearInputFields();
                    isEditMode = false;
                    lstLog.Enabled = true;
                }
            }
            else
            {
                var newItem = new WorkLogItem
                {
                    TimeStamp = dtTimeStamp.Value,
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    Author = txtAuthor.Text
                };
                _formData.Add(newItem);
                RefreshLogList();
                ClearInputFields();
                lstLog.Enabled = true;
                isEditMode = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstLog.SelectedIndex >= 0 && lstLog.SelectedIndex < _formData.Items.Count)
            {
                var item = _formData.Items[lstLog.SelectedIndex];
                dtTimeStamp.Value = item.TimeStamp;
                txtTitle.Text = item.Title;
                txtContent.Text = item.Content;
                txtAuthor.Text = item.Author;
                isEditMode = true;
                lstLog.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLog.SelectedIndex >= 0 && lstLog.SelectedIndex < _formData.Items.Count)
            {
                if (MessageBox.Show("Opravdu chcete odstranit vybraný záznam?", "Potvrzení odstranění", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _formData.Remove(lstLog.SelectedIndex);
                    RefreshLogList();
                    ClearInputFields();
                    isEditMode = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            isEditMode = false;
            lstLog.Enabled = true;
        }
    }
}
