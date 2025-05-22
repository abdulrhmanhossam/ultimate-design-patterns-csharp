namespace Visitor;

public class RemoteWorkShiftScheduleManagement : IScheduleManagement
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating report for remote work shift...");
    }

    public void CalculateOverTime()
    {
        Console.WriteLine("Calculateing over time for remote work shift...");
    }

    public void Accept(IScheduleManagementVisitor scheduleManagementVisitor)
    {
        scheduleManagementVisitor.Visit(this);
    }
}
