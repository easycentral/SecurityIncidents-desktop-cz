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
        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DaysLabel 
        {             
            get => lblDays.Text;
            set => lblDays.Text = value;
        }
        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string HoursLabel
        {
            get => lblHours.Text;
            set => lblHours.Text = value;
        }
        [Browsable(true)]
        [Category("Form")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string MinutesLabel
        {
            get => lblMinutes.Text;
            set => lblMinutes.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DurationText
        {
            get => Duration.ToString();
            set => Duration = TimeSpan.Parse(value);
        }

        [Browsable(true)]
        [Category("FormData")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public TimeSpan Duration
        {
            get => TimeSpan.FromMinutes((double)numDays.Value * 1440 + (double)numHours.Value * 60 + (double)numMinutes.Value);
            set
            {
                numDays.Value = (decimal)value.TotalDays;
                numHours.Value = (decimal)(value.TotalHours % 24);
                numMinutes.Value = (decimal)(value.TotalMinutes % 60);
            }
        }

        public TimeSpanControl()
        {
            InitializeComponent();
            //SetDuration();
        }

        //private void SetDuration()
        //{
        //    Duration=TimeSpan.FromMinutes((double)numDays.Value*1440+(double)numHours.Value*60+(double)numMinutes.Value);
        //}

    }
}
