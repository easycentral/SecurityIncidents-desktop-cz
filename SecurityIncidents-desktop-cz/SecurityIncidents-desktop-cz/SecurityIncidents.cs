using IncidentForms;
using IncidentForms.Components;
using IncidentForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
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



        private void mnuFileNewEvent_Click(object sender, EventArgs e)
        {
            FormWindow frm = new FormWindow { MdiParent = this };
            var EventFrm = new InfSecEvent();
            frm.SetForm(EventFrm);
            frm.Text = $"Zpráva o události informační bezpečnosti - {frm.FileName}";
            frm.Show();
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {

            using var dialog = new SaveFileDialog
            {
                Filter = "JSON soubory (*.json)|*.json",
                Title = "Uložit formulář"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var activeForm = this.ActiveMdiChild as FormWindow;
                if (activeForm != null)
                {
                    var frmdata = activeForm.Controls[0].Controls[0] as FormControl;
                    DataFile dataFile = new DataFile
                    {
                        FileType = frmdata.FormType,
                        FileData = frmdata.FormData
                    };
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true // pěkné odsazení
                    };
                    string json = JsonSerializer.Serialize(dataFile);
                    File.WriteAllText(dialog.FileName, json);
                    activeForm.FilePath = dialog.FileName;
                    activeForm.FileName = System.IO.Path.GetFileName(dialog.FileName);
                    activeForm.Text = $"{frmdata.FormTitle} - {activeForm.FileName}";
                }


            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            var activeForm = this.ActiveMdiChild as FormWindow;
            if (activeForm != null)
            {
                if (!string.IsNullOrEmpty(activeForm.FilePath))
                {
                    var frmdata = activeForm.Controls[0].Controls[0] as FormControl;
                    DataFile dataFile = new DataFile
                    {
                        FileType = frmdata.FormType,
                        FileData = frmdata.FormData
                    };
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true // pěkné odsazení
                    };
                    string json = JsonSerializer.Serialize(dataFile);
                    System.IO.File.WriteAllText(activeForm.FilePath, json);
                }
                else
                {
                    mnuFileSaveAs_Click(sender, e);
                }
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON soubory (*.json)|*.json",
                Title = "Otevřít formulář"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(dialog.FileName);
                DataFile? dataFile = JsonSerializer.Deserialize<DataFile>(json);

                

                if (dataFile != null)
                {
                    FormWindow frm = new FormWindow { MdiParent = this };
                    FormControl? formControl = null;
                    switch (dataFile.FileType)
                    {
                        case "InfSecurityEvent":
                            formControl = new InfSecEvent();
                            InfSecurityEvent data = JsonSerializer.Deserialize<InfSecurityEvent>(dataFile.FileData.ToString());
                            formControl.FormData = data;
                            break;


                    }
                    if (formControl != null)
                    {

                        frm.SetForm(formControl);
                        frm.FilePath = dialog.FileName;
                        frm.FileName = System.IO.Path.GetFileName(dialog.FileName);
                        frm.Text = $"{formControl.FormTitle} - {frm.FileName}";
                        frm.Show();
                    }
                }
            }

        }

        private void mnuFileExportMarkdown_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "MarkDown soubory (*.md)|*.md",
                Title = "Exportovat formulář"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var activeForm = this.ActiveMdiChild as FormWindow;
                if (activeForm != null)
                {
                    var frmdata = activeForm.Controls[0].Controls[0] as FormControl;
                    string md = frmdata.FormData.GetMarkDown();
                    System.IO.File.WriteAllText(dialog.FileName, md);
                    
                }


            }

        }
    }
}
