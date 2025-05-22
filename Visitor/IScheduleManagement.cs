namespace Visitor;

public interface IScheduleManagement
{
    void GenerateReport();
    void CalculateOverTime();
    void Accept(IScheduleManagementVisitor scheduleManagementVisitor);
}
