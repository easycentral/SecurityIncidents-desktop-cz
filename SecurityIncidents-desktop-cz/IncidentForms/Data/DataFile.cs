using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentForms.Data
{
    public class DataFile
    {
        public string FileType { get; set; } = string.Empty;
        public string FileVersion { get; set; } = "1.0";
        public object? FileData { get; set; } = null;
    }
}
