using System;

namespace StateCensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\StateCensusData.csv";
            Stateanalyser value = new Stateanalyser();
            value.AnalyseData(filePath);
            string fileofPath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\StateCode.csv";
            value.StateCodeAnalyser(fileofPath);
        }
    }
}


