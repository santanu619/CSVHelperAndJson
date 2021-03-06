using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVHelperAndJson
{
    class CSVHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"C:\Users\SANTANU\source\repos\CSVHelperAndJson\CSVHelperAndJson\Utility\Addresses.csv";
            string exportFilePath = @"C:\Users\SANTANU\source\repos\CSVHelperAndJson\CSVHelperAndJson\Utility\Export.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (AddressData addressData in records)
                {
                    Console.WriteLine("\t" + addressData.firstname);
                    Console.WriteLine("\t" + addressData.lastname);
                    Console.WriteLine("\t" + addressData.address);
                    Console.WriteLine("\t" + addressData.city);
                    Console.WriteLine("\t" + addressData.state);
                    Console.WriteLine("\t" + addressData.code);

                    Console.WriteLine("*******************Reading form Csv file and Write to Csv file");

                    using (var writer = new StreamWriter(exportFilePath))
                    using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csvExport.WriteRecords(records);
                    }
                }
            }
        }
    }
}