namespace Visitor;

public interface IScheduleManagementVisitor
{
    void Visit(DayShiftScheduleManagement dayShiftScheduleManagement);
    void Visit(NightShiftScheduleManagement nightShiftScheduleManagement);
    void Visit(RemoteWorkShiftScheduleManagement remoteWorkShiftScheduleManagement);
}
