namespace TemplateMethod;

interface ICVReportGeneration
{
    GeneratedReport GenerateCVReport(string cvFilePath);
    FileInfo ReadFile(string filePath);
    Data ExtractData(FileInfo file);
    AnalyzedData AnalyzeData(Data data);
}
