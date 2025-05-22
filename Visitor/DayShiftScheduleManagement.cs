namespace Visitor;

public class DayShiftScheduleManagement : IScheduleManagement
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating report for day shift...");
    }

    public void CalculateOverTime()
    {
        Console.WriteLine("Calculateing over time for day shift...");
    }

    public void Accept(IScheduleManagementVisitor scheduleManagementVisitor)
    {
        scheduleManagementVisitor.Visit(this);
    }
}
