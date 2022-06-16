using System;

namespace StateCensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\StateCensusData.csv";
            Stateanalyser getMethod = new Stateanalyser();
            getMethod.AnalyseData(filePath);
        }
    }
}


