using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace IncidentForms.Data
{
    public class Person : IReport
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Organization { get; set; } = "";
        public string OrgUnit { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";

        public string GetJSON()
        {
            return JsonSerializer.Serialize(this);
        }

        public int SetJSON(string json)
        {
            try
            {
                var data = JsonSerializer.Deserialize<Person>(json);
                if (data != null)
                {
                    this.Name = data.Name;
                    this.Address = data.Address;
                    this.Organization = data.Organization;
                    this.OrgUnit = data.OrgUnit;
                    this.Email = data.Email;
                    this.Phone = data.Phone;
                }
            }
            catch
            {
                return -1;
            }
            return 0;
        }
        public string GetMarkDown()
        {
            return "";
        }
    }


}
