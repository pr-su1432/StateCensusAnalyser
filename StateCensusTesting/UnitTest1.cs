namespace StateCensusTesting
{
    public class Tests
    {

         [Test]
         public void GivenStatesCensusCSVFile_CheckNumberOfRecordsMatches()
         {
             int expected = 29;
             string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\StateCensusData.csv";
             StateCensusAnalyser.Stateanalyser value = new StateCensusAnalyser.Stateanalyser();
             int actual = value.AnalyseData(filePath);
             Assert.AreEqual(expected, actual);
         }
         [Test]
         public void GivenInvalidFile_ShouldThrowInvalidFileException()
         {
             try
             {
                 int expected = 29;
                 string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\StateCode.csv";
                 StateCensusAnalyser.Stateanalyser data = new StateCensusAnalyser.Stateanalyser();
                 int actual = data.AnalyseData(filePath);
                 Assert.AreEqual(expected, actual);
             }
             catch (Exception ex)
             {
                 Assert.AreEqual("Invalid File", ex.Message);
             }
         }
         [Test]
         public void GivenInvalidFileType_ShouldThrowInvalidFileTypeException()
         {
             try
             {
                 int expected = 29;
                 string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCensusData.txt";
                 StateCensusAnalyser.Stateanalyser example = new StateCensusAnalyser.Stateanalyser();
                 int actual = example.AnalyseData(filePath);
                 Assert.AreEqual(expected, actual);
             }
             catch (Exception ex)
             {
                 Assert.AreEqual("Invalid File Type", ex.Message);
             }
         }
         [Test]
         public void GivenInvalidDelimiterFile_ShouldThrowInvalidDelimiterFileTypeException()
         {
             try
             {
                 int expected = 29;
                 string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\InvalidDelimeterStateCensusData.csv";
                 StateCensusAnalyser.Stateanalyser name = new StateCensusAnalyser.Stateanalyser();
                 int actual = name.AnalyseData(filePath);
                 Assert.AreEqual(expected, actual);
             }
             catch (Exception ex)
             {
                 Assert.AreEqual("Incorrect Delimiter", ex.Message);
             }
         }
         [Test]
         public void GivenInvalidHeaderFile_ShouldThrowInvalidHeaderFileTypeException()
         {
             try
             {
                 int expected = 29;
                 string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\InvalidHeaderCensusData.csv";
                 StateCensusAnalyser.Stateanalyser value = new StateCensusAnalyser.Stateanalyser();
                 int actual = value.AnalyseData(filePath);
                 Assert.AreEqual(expected, actual);
             }
             catch (Exception ex)
             {
                 Assert.AreEqual("Incorrect Header", ex.Message);
             }
         }
        [Test]
        public void GivenStatesCodeCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 37;
            string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\StateCode.csv";
            StateCensusAnalyser.Stateanalyser exa = new StateCensusAnalyser.Stateanalyser();
            int actual = exa.StateCodeAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenInvalidCodeFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 37;
                string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\StateCensusData.csv";
                StateCensusAnalyser.Stateanalyser data = new StateCensusAnalyser.Stateanalyser();
                int actual = data.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidCodeFileType_ShouldThrowInvalidFileTypeException()
        {
            try
            {
                int expected = 37;
                string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\StateCensusData.txt";
                StateCensusAnalyser.Stateanalyser value = new StateCensusAnalyser.Stateanalyser();
                int actual = value.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidDelimiterFile_ShouldThrowIncorrectDelimiterException()
        {
            try
            {
                int expected = 37;
                string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\InvaliDelimeterStateCode.csv";
                StateCensusAnalyser.Stateanalyser data = new StateCensusAnalyser.Stateanalyser();
                int actual = data.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidHeaderFile_ShouldThrowIncorrectHeaderException()
        {
            try
            {
                int expected = 37;
                string filePath = @"C:\prasanna\prasanna bridgelabzs\StateCensusAnalyser\StateCensusAnalyser\InvalidHeaderStateCode.csv";
                StateCensusAnalyser.Stateanalyser value = new StateCensusAnalyser.Stateanalyser();
                int actual = value.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }

    }
}
