namespace Visitor;

public class CalculateBounsVisitor : IScheduleManagementVisitor
{
    public void Visit(DayShiftScheduleManagement dayShiftScheduleManagement)
    {
        Console.WriteLine("Calculating Bouns for day shift...");
    }

    public void Visit(NightShiftScheduleManagement nightShiftScheduleManagement)
    {
        Console.WriteLine("Calculating Bouns for night shift...");
    }

    public void Visit(RemoteWorkShiftScheduleManagement remoteWorkShiftScheduleManagement)
    {
        Console.WriteLine("Calculating Bouns for remote work shift...");
    }
}
