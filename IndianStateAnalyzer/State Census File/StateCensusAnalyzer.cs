using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyzer
{
    public class StateCensusAnalyzer
    {
        public int ReadStateCensusData(string filePath)
        {
            if (!File.Exists(filePath))
                throw new StateCensusException(StateCensusException.ExceptionType.FILE_INCORRECT, "Incorrect File Path");
            if(!filePath.EndsWith(".csv"))
                throw new StateCensusException(StateCensusException.ExceptionType.TYPE_INCORRECT, "Incorrect File Type");
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if(header.Contains("/"))
                throw new StateCensusException(StateCensusException.ExceptionType.DELIMETER_INCORRECT, "Incorrect Delimeter");
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvReader (reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCensusDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data.State);
                    Console.WriteLine(data.Population);
                    Console.WriteLine(data.AreaInSqKm);
                    Console.WriteLine(data.DensityPerSqKm);
                }
                return records.Count() - 1;
            }
        }
        public bool ReadStateCensusData(string filePath, string actualHeader)
        {
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Equals(actualHeader))
                return true;
            else
                throw new StateCensusException(StateCensusException.ExceptionType.HEADER_INCORRECT, "Incorrect Header");
        }
    }
}
