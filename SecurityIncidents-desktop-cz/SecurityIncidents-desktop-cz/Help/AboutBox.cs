using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SecurityIncidents_desktop_cz.Help
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {

            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version?.ToString() ?? "neznámá";
            var buildDate = File.GetLastWriteTime(assembly.Location);

            lblVersion.Text = $"Verze: {version} (build: {buildDate:yyyy-MM-dd HH:mm})";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void lnkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = lnkSource.Text,
                UseShellExecute = true
            });

        }

        private void lnkGPL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = lnkGPL.Text,
                UseShellExecute = true
            });
        }
    }
}
