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
    
    public partial class InfSecEvent : FormControl
    {

        [Browsable(false)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string FormType
        {
            get
            {
                return "InfSecurityEvent";
            }
        }

        [Browsable(false)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string FormTitle
        {
            get
            {
                return "Zpráva o události informační bezpečnosti";
            }
        }

        [Browsable(false)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public override IReport? FormData
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
                if (value == null || value.GetType() != typeof(InfSecurityEvent))
                    return;
                InfSecurityEvent data = (InfSecurityEvent) value;
                dateEventDate.Value = data.EventDate;
                txtEventID.Text = data.EventID;
                lstRelated.Items = data.RelatedIDs;
                lstAttachment.Items = data.Attachments;
                persNotifier.PersonData = data.Notifier;
                txtDescription.Text = data.Description;
                dtEventStartDateTime.Value = data.EventStartDateTime;
                dtEventDetectionDateTime.Value = data.EventDetectionDateTime;
                dtEventReportDateTime.Value = data.EventReportDateTime;
                chkClosed.Checked = data.ReportClosed;
                tsDuration.Duration = data.EventDuration;
                
            }
        }


        public InfSecEvent()
        {
            InitializeComponent();
        }

    }
}
