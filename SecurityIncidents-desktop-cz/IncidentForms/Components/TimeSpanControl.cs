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
            
            get => new TimeSpan((int)numDays.Value, (int)numHours.Value, (int)numMinutes.Value, 0);
            set
            {
                numDays.Value = (decimal)value.Days;
                numHours.Value = (decimal)(value.Hours);
                numMinutes.Value = (decimal)(value.Minutes);
            }
        }

        public TimeSpanControl()
        {
            InitializeComponent();
            
        }

        

    }
}
