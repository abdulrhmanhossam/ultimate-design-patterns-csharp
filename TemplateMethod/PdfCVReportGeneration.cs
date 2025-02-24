namespace TemplateMethod;

class PdfCVReportGeneration : CVReportGeneration
{
    protected override Data ExtractData(FileInfo file)
    {
        Console.WriteLine($"extracting data from PDF");
        return null!;
    }

    protected override GeneratedReport GenerateReportOf(AnalyzedData analyzedData)
    {
        Console.WriteLine($"generating report from {analyzedData}");
        return new GeneratedReport(true);
    }
}
