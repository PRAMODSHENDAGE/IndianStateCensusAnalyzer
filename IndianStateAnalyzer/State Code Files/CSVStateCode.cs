using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyzer.State_Code_Files
{
    public class CSVStateCode
    {
        public int ReadStateCodeData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCodeDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data.SrNo);
                    Console.WriteLine(data.StateName);
                    Console.WriteLine(data.TIN);
                    Console.WriteLine(data.StateCode);
                }
                return records.Count() - 1;
            }
        }
    }
}
