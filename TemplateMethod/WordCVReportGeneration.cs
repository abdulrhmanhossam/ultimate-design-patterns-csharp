namespace TemplateMethod;

class WordCVReportGeneration : CVReportGeneration
{
    protected override Data ExtractData(FileInfo file)
    {
        Console.WriteLine("extracting data from word file");
        return null!;
    }

    protected override GeneratedReport GenerateReportOf(AnalyzedData analyzedData)
    {
        Console.WriteLine($"generating report from {analyzedData}");
        return new GeneratedReport(false);
    }
}
