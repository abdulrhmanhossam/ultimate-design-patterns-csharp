namespace Visitor;

public class NightShiftScheduleManagement : IScheduleManagement
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating report for night shift...");
    }

    public void CalculateOverTime()
    {
        Console.WriteLine("Calculateing over time for night shift...");
    }

    public void Accept(IScheduleManagementVisitor scheduleManagementVisitor)
    {
        scheduleManagementVisitor.Visit(this);
    }
}
