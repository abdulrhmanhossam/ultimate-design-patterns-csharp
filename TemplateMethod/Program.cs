
using TemplateMethod;

class Program
{
    static void Main()
    {
        CVReportGeneration pdfCVReportGeneration = new PdfCVReportGeneration();
        GeneratedReport pdfReport = pdfCVReportGeneration
            .GenerateCVReport("/tmp/cv-001.pdf");
        Console.WriteLine(pdfReport.IsPassed);

        CVReportGeneration wordCVReportGeneration = new WordCVReportGeneration();
        GeneratedReport wordReport = wordCVReportGeneration
            .GenerateCVReport("/tmp/cv-001.word");
        Console.WriteLine(wordReport.IsPassed);

        CVReportGeneration imageCVReportGeneration = new ImageCVReportGeneration();
        GeneratedReport imageReport = imageCVReportGeneration
            .GenerateCVReport("/tmp/cv-001.jpeg");
        Console.WriteLine(imageReport.IsPassed);


    }
}
