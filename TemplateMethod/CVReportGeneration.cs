namespace TemplateMethod;

abstract class CVReportGeneration
{
    public GeneratedReport GenerateCVReport(string cvFilePath)
    {
        var file = ReadFile(cvFilePath);
        var extractedData = ExtractData(file);
        var analyzedData = AnalyzeData(extractedData);
        return GenerateReportOf(analyzedData);
    }

    protected abstract Data ExtractData(FileInfo file);

    private FileInfo ReadFile(string filePath)
    {
        Console.WriteLine($"reading file from {filePath}");
        return null!;
    }

    private AnalyzedData AnalyzeData(Data data)
    {
        Console.WriteLine($"analyzeing data from {data}");
        return null!;
    }
    protected abstract GeneratedReport GenerateReportOf(AnalyzedData analyzedData);
}
