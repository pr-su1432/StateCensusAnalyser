using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyser
{
    public class Stateanalyser
    {
        public int AnalyseData(string filePath)
        {
            if (Path.GetExtension(filePath) == ".csv")
            {
                try
                {
                    if (filePath.Contains("CensusData.csv"))
                    {
                        int numberOfRecords;
                        using (var reader = new StreamReader(filePath))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var details = csv.GetRecords<StatesModel>().ToList();
                            numberOfRecords = details.Count();
                            foreach (var data in details)
                            {
                                Console.WriteLine("State: " + data.State + "\nPopulation: " + data.Population + "\nAreaInSqKm: " + data.AreaInSqKm
                                    + "\nDensityPerSqKm: " + data.DensityPerSqKm + "\n");
                            }
                        }
                        return numberOfRecords;
                    }
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_FILE, "Invalid File");
                }
                catch (CsvHelper.MissingFieldException)
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INCORRECT_DELIMITER, "Incorrect Delimiter");
                }
                catch (CsvHelper.HeaderValidationException)
                {
                    throw new CustomExceptions(CustomExceptions.ExceptionType.INCORRECT_HEADER, "Incorrect Header");
                }
            }
            throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_FILE_TYPE, "Invalid File Type");
        }
    }
}
