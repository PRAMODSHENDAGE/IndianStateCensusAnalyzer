using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyzer
{
    public class CSVStateCensus
    {
        public int ReadStateCensusData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
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
    }
}
