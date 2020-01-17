namespace SOLID
{
    public class DeveloperReport
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public DeveloperLevelEnum Level { get; set; }
    public int WorkingHours { get; set; }
    public double HourlyRate { get; set; }
    public double CalculateSalary() => WorkingHours * HourlyRate;
    }
}