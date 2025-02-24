namespace TemplateMethod;

class ImageCVReportGeneration : ICVReportGeneration
{
    public GeneratedReport GenerateCVReport(string cvFilePath)
    {
        var file = ReadFile(cvFilePath);
        var extractedData = ExtractData(file);
        var analyzedData = AnalyzeData(extractedData);
        return GenerateReportOf(analyzedData);
    }

    private GeneratedReport GenerateReportOf(AnalyzedData analyzedData)
    {
        Console.WriteLine($"generating report from {analyzedData}");
        return new GeneratedReport(true);
    }

    public FileInfo ReadFile(string filePath)
    {
        Console.WriteLine($"reading file from {filePath}");
        return null!;
    }

    public Data ExtractData(FileInfo file)
    {
        Console.WriteLine("extracting data from an image");
        return null!;
    }

    public AnalyzedData AnalyzeData(Data data)
    {
        Console.WriteLine($"analyzeing data from {data}");
        return null!;
    }
}
