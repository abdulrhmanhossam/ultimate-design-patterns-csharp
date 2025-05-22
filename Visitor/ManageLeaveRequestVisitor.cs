namespace Visitor;

public class ManageLeaveRequestVisitor : IScheduleManagementVisitor
{
    public void Visit(DayShiftScheduleManagement dayShiftScheduleManagement)
    {
        Console.WriteLine("Manageing leave requests for day shift.");
    }

    public void Visit(NightShiftScheduleManagement nightShiftScheduleManagement)
    {
        Console.WriteLine("Manageing leave requests for night shift.");
    }

    public void Visit(RemoteWorkShiftScheduleManagement remoteWorkShiftScheduleManagement)
    {
        Console.WriteLine("Manageing leave requests for remote work shift.");
    }
}
