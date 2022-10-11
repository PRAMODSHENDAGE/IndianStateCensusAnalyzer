using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyzer.State_Code_Files
{
    public class StateCodeAnalyzer
    {
        public int ReadStateCodeData(string filePath)
        {
            if (!File.Exists(filePath))
                throw new StateCodeException(StateCodeException.ExceptionType.FILE_INCORRECT, "Incorrect File Path");
            if (!filePath.EndsWith(".csv"))
                throw new StateCodeException(StateCodeException.ExceptionType.TYPE_INCORRECT, "Incorrect File Type");
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Contains("/"))
                throw new StateCodeException(StateCodeException.ExceptionType.DELIMETER_INCORRECT, "Incorrect Delimeter");
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
        public bool ReadStateCodeData(string filePath, string actualHeader)
        {
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Equals(actualHeader))
                return true;
            else
                throw new StateCodeException(StateCodeException.ExceptionType.HEADER_INCORRECT, "Incorrect Header");
        }
    }
}
