
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ContactManagement.Application.Models;

namespace ContactManagement.WinForms.UI
{
    public static class CsvExporter
    {
        public static string BuildContactsCsv(IEnumerable<Contact> contacts)
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Join(",",
                "Id",
                "FirstName",
                "LastName",
                "Email",
                "Phone",
                "Category",
                "Company",
                "Website",
                "Notes",
                "Address",
                "CreatedAt"));

            foreach (var c in contacts)
            {
                sb.AppendLine(string.Join(",",
                    Csv(c.Id.ToString(CultureInfo.InvariantCulture)),
                    Csv(c.FirstName),
                    Csv(c.LastName),
                    Csv(c.Email),
                    Csv(c.Phone),
                    Csv(c.Category.ToString()),
                    Csv(c.Company),
                    Csv(c.Website),
                    Csv(c.Notes),
                    Csv(c.Address),
                    Csv(c.CreatedAt.ToString("o", CultureInfo.InvariantCulture))
                ));
            }

            return sb.ToString();
        }

        private static string Csv(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            bool mustQuote =
                value.Contains(",") ||
                value.Contains("\"") ||
                value.Contains("\r") ||
                value.Contains("\n");

            if (value.Contains("\""))
                value = value.Replace("\"", "\"\"");

            return mustQuote ? $"\"{value}\"" : value;
        }
    }
}
