using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentForms.Data
{
    public class WorkLog : IReport
    {
        public List<WorkLogItem> Items { get; set; } = new List<WorkLogItem>();
        
        public string GetMarkDown()
        {
            StringBuilder md = new StringBuilder();
            md.AppendLine("# Záznam činnosti");
            md.AppendLine();
            foreach (var item in Items)
            {
                md.AppendLine(item.GetMarkDown());
            }
            return md.ToString();
        }
        public void Add(WorkLogItem item)
        {
            Items.Add(item);
            Items = Items.OrderBy(i => i.TimeStamp).ToList();
        }
        public bool Remove(int index)
        {
            if (index < 0 || index >= Items.Count)
            {
                return false;
            }
            var item = Items[index];

            if (item != null)
            {
                Items.Remove(item);
                return true;
            }
            Items = Items.OrderBy(i => i.TimeStamp).ToList();
            return false;
        }
    }
}
