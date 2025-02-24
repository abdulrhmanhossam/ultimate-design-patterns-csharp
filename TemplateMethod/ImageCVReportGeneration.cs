namespace TemplateMethod;

class ImageCVReportGeneration : CVReportGeneration
{
    protected override Data ExtractData(FileInfo file)
    {
        Console.WriteLine("extracting data from an image");
        return null!;
    }

    protected override GeneratedReport GenerateReportOf(AnalyzedData analyzedData)
    {
        Console.WriteLine($"generating report from {analyzedData}");
        return new GeneratedReport(false);
    }
}
