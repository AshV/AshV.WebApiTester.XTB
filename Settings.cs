using System.Collections.Generic;
using System.Windows.Forms;

namespace AshV.WebApiTester.XTB
{
    /// <summary>
    /// This class can help you to store settings for your plugin
    /// </summary>
    /// <remarks>
    /// This class must be XML serializable
    /// </remarks>
    public class Settings
    {
        public string LastUsedOrganizationWebappUrl { get; set; }

        public List<Request> Requests { get; set; } = new List<Request>();
    }

    public class Request
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Method { get; set; }
        public string Uri { get; set; }

        public string Body { get; set; }

        public List<Header> Headers { get; set; } = new List<Header>();

        public override bool Equals(object obj)
        {
            return obj is Request request &&
                   Name == request.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Header
    {
        public Header()
        { }


        public Header(DataGridViewRow row)
        {
            Enable = (bool)row.Cells[0].Value;
            Name = row.Cells[1].Value?.ToString() ?? string.Empty;
            Value = row.Cells[2].Value?.ToString() ?? string.Empty;
        }

        public Header(bool enable, string name, string value)
        {
            Enable = enable;
            Name = name;
            Value = value;
        }

        public bool Enable { get; set; }
        public string Name { get; set; }

        public string Value { get; set; }
    }
}