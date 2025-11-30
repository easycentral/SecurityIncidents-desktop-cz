using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentForms.Utils
{
    public class ColumnDefinition
    {
        public string PropertyName { get; set; } = "";
        public int Width { get; set; }
        public string Header { get; set; } = "";

        public ColumnDefinition() { }
        public ColumnDefinition(string propertyname, int width, string header)
        {
            PropertyName = propertyname;
            Width = width;
            Header = header;
        }
    }
}
