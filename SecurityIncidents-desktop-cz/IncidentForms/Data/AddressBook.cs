using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentForms.Data
{
    public class AddressBook : IReport
    {
        private readonly List<AddressBookItem> _items = new List<AddressBookItem>();
        public IReadOnlyList<AddressBookItem> Items => _items.AsReadOnly();
        public string GetMarkDown()
        {
            StringBuilder md = new StringBuilder();
            md.AppendLine("# Adresář kontaktů");
            md.AppendLine();
            foreach (var item in _items)
            {
                md.AppendLine(item.GetMarkDown());
            }
            return md.ToString();
        }
        public void Add(AddressBookItem item)
        {

            if (_items.Any(x => x.ShortName.Equals(item.ShortName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException($"ShortName '{item.ShortName}' už existuje.");
            }
            _items.Add(item);
        }

        public bool Remove(string shortName)
        {
            var item = _items.FirstOrDefault(x => x.ShortName.Equals(shortName, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                _items.Remove(item);
                return true;
            }
            return false;


        }
        public void Clear() 
        {
            _items.Clear();
        }

    }
}
