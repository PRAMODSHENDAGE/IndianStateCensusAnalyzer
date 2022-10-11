using IndianStateAnalyzer;
using IndianStateAnalyzer.State_Code_Files;

//UC 1 For State Census Analyzer
string filePathStateCensus = @"D:\RFP\PP\IndianStateCensusAnalyzer\IndianStateAnalyzer\CSV FIles\StateCensusData.csv";
StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
int StateCensusRecords = analyzer.ReadStateCensusData(filePathStateCensus);
CSVStateCensus census = new CSVStateCensus();
int censusRecords = census.ReadStateCensusData(filePathStateCensus);
if(StateCensusRecords == censusRecords)
    Console.WriteLine("number of records matches");

//UC 2 For State Code Analyzer
string filePathStateCode = @"D:\RFP\PP\IndianStateCensusAnalyzer\IndianStateAnalyzer\CSV FIles\StateCode.csv";
StateCodeAnalyzer Analyzer = new StateCodeAnalyzer();
int StateCodeRecords = Analyzer.ReadStateCodeData(filePathStateCode);
CSVStateCode code = new CSVStateCode();
int codeRecords = code.ReadStateCodeData(filePathStateCode);
if (StateCodeRecords == codeRecords)
    Console.WriteLine("number of records matches");
