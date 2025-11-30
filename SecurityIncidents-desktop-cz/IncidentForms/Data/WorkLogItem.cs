using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace IncidentForms.Data
{
    public class WorkLogItem : IReport
    {
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public string Author { get; set; } = "";
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        
        public string GetMarkDown()
        {
            StringBuilder md = new StringBuilder();
            md.AppendLine($"**{TimeStamp.ToString("g")} - {Author}**: {Title}");
            md.AppendLine();
            md.AppendLine(Content);
            md.AppendLine();
            return md.ToString();
        }
    }
}
