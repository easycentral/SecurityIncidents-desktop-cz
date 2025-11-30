using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentForms.Data
{
    public class AddressBookItem: IReport
    {
        public string ShortName { get; set; } = "";
        public Person Contact { get; set; } = new();

        public string GetMarkDown()
        {
            StringBuilder md = new StringBuilder();
            md.AppendLine($"## {ShortName}");
            md.AppendLine();
            md.AppendLine(Contact.GetMarkDown());
            md.AppendLine();
            return md.ToString();
        }
    }
}
