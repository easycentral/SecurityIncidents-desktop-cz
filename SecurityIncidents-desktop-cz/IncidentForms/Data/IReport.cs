using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentForms.Data
{
    public interface IReport
    {
        public string GetJSON();
        public int SetJSON(string json);
        public string GetMarkDown();


    }
}
