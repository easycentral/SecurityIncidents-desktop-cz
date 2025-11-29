using IncidentForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IncidentForms.Components
{
    public class FormControl : UserControl
    {
        [Browsable(false)]        
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual object? FormData { get; set; }

        [Browsable(false)]

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string FormType { get; } = "";

        [Browsable(false)]

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string FormTitle { get; } = "";
    }
}
