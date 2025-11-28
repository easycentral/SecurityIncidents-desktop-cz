using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IncidentForms.Components
{
    public partial class TimeSpanControl : UserControl
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DurationText
        {
            get => Duration.ToString();
            set => Duration = TimeSpan.Parse(value);
        }

        [Browsable(false)]
        public TimeSpan Duration { get; private set; }

        public TimeSpanControl()
        {
            InitializeComponent();
            SetDuration();
        }

        private void SetDuration()
        {
            Duration=TimeSpan.FromMinutes((double)numDays.Value*1440+(double)numHours.Value*60+(double)numMinutes.Value);
        }
    }
}
