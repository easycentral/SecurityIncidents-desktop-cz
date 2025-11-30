using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace IncidentForms.Utils
{
    public class StringFormatter
    {
        public static string ToTableString(object obj, List<ColumnDefinition> columns)
        {
            if (obj == null) return "Objekt je null.";

            var sb = new StringBuilder();
            var type = obj.GetType();



            // Dynamicky získáme hodnoty
            var row = new StringBuilder();
            foreach (var column in columns)
            {
                var prop = type.GetProperty(column.PropertyName, BindingFlags.Public | BindingFlags.Instance);
                if (prop != null)
                {
                    var value = prop.GetValue(obj, null)?.ToString() ?? "null";

                    if (value.Length > column.Width)
                    {
                        value = value.Substring(0, column.Width);
                    }

                    // Zde se použije šířka z definice sloupce
                    row.AppendFormat("{0,-" + column.Width + "}", value);
                }
                else
                {

                    var naValue = "N/A";
                    if (naValue.Length > column.Width)
                    {
                        naValue = naValue.Substring(0, column.Width);
                    }
                    row.AppendFormat("{0,-" + column.Width + "}", naValue);

                }
            }
            sb.AppendLine(row.ToString());

            return sb.ToString();
        }

        public static string GetHeaderString(List<ColumnDefinition> columns)
        {
            var sb = new StringBuilder();
            // Dynamicky vytvoříme hlavičky tabulky s definovanou šířkou
            var header = new StringBuilder();
            foreach (var column in columns)
            {
                header.AppendFormat("{0,-" + column.Width + "}", column.Header);
            }
            sb.AppendLine(header.ToString());


            return sb.ToString();
        }
    }
}

