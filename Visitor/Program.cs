using Visitor;


var scheduleManagementList = new List<IScheduleManagement>
{
    new DayShiftScheduleManagement(),
    new NightShiftScheduleManagement(),
    new RemoteWorkShiftScheduleManagement()
};

foreach (var scheduleManagement in scheduleManagementList)
{
    scheduleManagement.Accept(new ManageLeaveRequestVisitor());
    scheduleManagement.Accept(new CalculateBounsVisitor());
}