using System;
using System.Collections.Generic;
using System.Text;

namespace CSVHelperAndJson
{
    class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVToJSON()
        {
            string importFilePath = " ";
            string exportFilePath = " ";
            using(var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))

        }
    }
}
