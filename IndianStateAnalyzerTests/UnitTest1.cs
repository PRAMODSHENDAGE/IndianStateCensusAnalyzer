using NUnit.Framework;
using IndianStateAnalyzer;
using IndianStateAnalyzer.State_Code_Files;

namespace IndianStateAnalyzerTests
{
    public class Tests
    {
        public string filePathStateCensus = @"D:\RFP\PP\IndianStateCensusAnalyzer\IndianStateAnalyzer\CSV FIles\StateCensusData.csv";
        public string filePathStateCode = @"D:\RFP\PP\IndianStateCensusAnalyzer\IndianStateAnalyzer\CSV FIles\StateCode.csv";
        //TC 1.1
        [Test]
        public void GivenStateCensusData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            CSVStateCensus stateCensus = new CSVStateCensus();
            Assert.AreEqual(stateCensus.ReadStateCensusData(filePathStateCensus), analyzer.ReadStateCensusData(filePathStateCensus));
        }
        //TC 1.2
        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(filePathStateCensus);
            }
            catch(StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Path");
            }
        }
        //TC 1.3
        [Test]
        public void GivenStateCensusDataTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(filePathStateCensus);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Path");
            }
        }
        //TC 1.4
        [Test]
        public void GivenStateCensusDataFileDelimeterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            try
            {
                int records = analyzer.ReadStateCensusData(filePathStateCensus);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delimeter");
            }
        }
        //TC 1.5
        [Test]
        public void GivenStateCensusDataFileHeaderIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            try
            {
                bool records = analyzer.ReadStateCensusData(filePathStateCensus, "state/city,population");
                Assert.IsTrue(records);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }
        //TC 2.1
        [Test]
        public void GivenStateCodeData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            StateCodeAnalyzer Analyzer = new StateCodeAnalyzer();
            CSVStateCode stateCode = new CSVStateCode();
            Assert.AreEqual(stateCode.ReadStateCodeData(filePathStateCode), Analyzer.ReadStateCodeData(filePathStateCode));
        }
        //TC 2.2
        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer Analyzer = new StateCodeAnalyzer();
            try
            {
                int records = Analyzer.ReadStateCodeData(filePathStateCode);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Path");
            }
        }
        //TC 2.3
        [Test]
        public void GivenStateCodeDataTypeIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer Analyzer = new StateCodeAnalyzer();
            try
            {
                int records = Analyzer.ReadStateCodeData(filePathStateCode);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect File Path");
            }
        }
        //TC 2.4
        [Test]
        public void GivenStateCodeDataFileDelimeterIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer Analyzer = new StateCodeAnalyzer();
            try
            {
                int records = Analyzer.ReadStateCodeData(filePathStateCode);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Delimeter");
            }
        }
        //TC 2.5
        [Test]
        public void GivenStateCodeDataFileHeaderIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer Analyzer = new StateCodeAnalyzer();
            try
            {
                bool records = Analyzer.ReadStateCodeData(filePathStateCode, "SrNo,StateName/TIN,StateCode");
                Assert.IsTrue(records);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect Header");
            }
        }
    }
}