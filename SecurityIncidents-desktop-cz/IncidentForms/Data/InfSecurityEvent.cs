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
        

        public string GetMarkDown()
        {
            StringBuilder md = new StringBuilder();
            md.AppendLine($"# Zpráva o události informační bezpečnosti");
            md.AppendLine();
            md.AppendLine($"**ID události:** {EventID}");
            md.AppendLine();
            md.AppendLine($"**Datum události:** {EventDate:dd.MM.yyyy}");
            md.AppendLine();
            md.AppendLine($"**Související ID událostí:**");
            md.AppendLine();
            
            foreach (var id in RelatedIDs)
            {
                md.AppendLine($"- {id}");
            }
            md.AppendLine("---");
            md.AppendLine();
            md.AppendLine();
            md.AppendLine($"## Oznamovatel");
            md.AppendLine();
            md.AppendLine(Notifier.GetMarkDown());
            md.AppendLine();
            md.AppendLine($"## Popis události:");
            md.AppendLine();
            md.AppendLine(Description);
            md.AppendLine();
            md.AppendLine($"## Podrobnosti události:");
            md.AppendLine();
            md.AppendLine("|||");
            md.AppendLine("|-|-|");
            md.AppendLine($"|**Datum a čas začátku události:** | {EventStartDateTime:dd.MM.yyyy HH:mm}|");
            md.AppendLine($"|**Datum a čas zjištění události:** | {EventDetectionDateTime:dd.MM.yyyy HH:mm}|");
            md.AppendLine($"|**Datum a čas nahlášení události:** | {EventReportDateTime:dd.MM.yyyy HH:mm}|");
            md.AppendLine($"|**Doba trvání události:** | {EventDuration.Days} d {EventDuration.Hours} hod {EventDuration.Minutes} min|");
            md.AppendLine();
            md.AppendLine("---");
            md.AppendLine();
            md.AppendLine($"**Stav odezvy na událost:** {(ReportClosed ? "Uzavřeno" : "Otevřeno")}");
            md.AppendLine();
            md.AppendLine("---");
            md.AppendLine();
            md.AppendLine($"**Přílohy:**");
            foreach (var att in Attachments)
            {
                md.AppendLine($"- {att}");
            }

            return md.ToString();
        

        }

    }
}
