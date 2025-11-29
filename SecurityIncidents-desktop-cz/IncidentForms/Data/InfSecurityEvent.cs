using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentForms.Data
{
    public class InfSecurityEvent : IReport
    {
        public DateTime EventDate { get; set;  }= DateTime.Now.Date;
        public string EventID { get; set; } = "";
        public List<string> RelatedIDs { get; set; }= new List<string>();
        public List<string> Attachments { get; set; } = new List<string>();
        public Person Notifier { get; set; }=new Person();
        public string Description { get; set; } = "";
        public DateTime EventStartDateTime { get; set; } = DateTime.Now;
        public DateTime EventDetectionDateTime { get; set; }=DateTime.Now;
        public DateTime EventReportDateTime { get; set; } = DateTime.Now;
        public bool ReportClosed { get; set; }=false;
        public TimeSpan EventDuration { get; set; } = new TimeSpan();
        

        public string GetJSON()
        {
            return "";
        }

        public int SetJSON(string json)
        {
            return 0;
        }
        public string GetMarkDown()
        {
            return "";
        }

    }
}
