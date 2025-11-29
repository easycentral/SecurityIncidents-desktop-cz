using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IncidentForms.Components;
using IncidentForms.Data;

namespace IncidentForms
{
    public partial class InfSecEvent : UserControl
    {
        [Browsable(true)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public InfSecurityEvent InfSecurityEventData
        {
            get
            {
                InfSecurityEvent data = new InfSecurityEvent();
                data.EventDate = dateEventDate.Value.Date;
                data.EventID = txtEventID.Text;
                data.RelatedIDs = lstRelated.Items;
                data.Attachments = lstAttachment.Items;
                data.Notifier=persNotifier.PersonData;
                data.Description = txtDescription.Text;
                data.EventStartDateTime = dtEventStartDateTime.Value;
                data.EventDetectionDateTime = dtEventDetectionDateTime.Value;
                data.EventReportDateTime = dtEventReportDateTime.Value;
                data.ReportClosed = chkClosed.Checked;
                data.EventDuration = tsDuration.Duration;
                return data;
            }
            set
            {
                dateEventDate.Value = value.EventDate;
                txtEventID.Text = value.EventID;
                lstRelated.Items = value.RelatedIDs;
                lstAttachment.Items = value.Attachments;
                persNotifier.PersonData = value.Notifier;
                txtDescription.Text = value.Description;
                dtEventStartDateTime.Value = value.EventStartDateTime;
                dtEventDetectionDateTime.Value = value.EventDetectionDateTime;
                dtEventReportDateTime.Value = value.EventReportDateTime;
                chkClosed.Checked = value.ReportClosed;
                tsDuration.Duration = value.EventDuration;
                
            }
        }


        public InfSecEvent()
        {
            InitializeComponent();
        }

    }
}
