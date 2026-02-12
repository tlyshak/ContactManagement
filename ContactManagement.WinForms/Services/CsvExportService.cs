using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using ContactManagement.Application.Models;
using CsvHelper.Configuration;
using CsvHelper;

namespace ContactManagement.WinForms.Services
{
    public static class CsvExportService
    {
        public static void Export(string filePath, IEnumerable<Contact> contacts)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                Encoding = new UTF8Encoding(true)
            };

            using (var writer = new StreamWriter(filePath, false, config.Encoding))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(contacts);
            }
        }
    }
}
