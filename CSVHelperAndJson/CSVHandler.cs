using System;
using System.Collections.Generic;
using System.Text;

namespace CSVHelperAndJson
{
    class CSVHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = ;
            string export FilePath = ;

            using(var reader = new StreamReader(importFilePath))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data successfully from addesses csv.");
                foreach(AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.firstName);
                    Console.Write("\t" + addressData.lastName);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.state);
                    Console.Write("\t" + addressData.code);

                    Console.WriteLine("************Reading from csv file and Write to csv file************");

                    using (var writer = new StreamWriter(exportFilePath))
                    using(var csvExport=new )

                }
            }
        }
    }
}
