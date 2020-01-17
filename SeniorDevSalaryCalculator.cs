using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
public class SeniorDevSalaryCalculator : ISalaryCalculator
{
    public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
        reports
            .Where(r => r.Level == DeveloperLevelEnum.Senior)
            .Select(r => r.CalculateSalary() * 1.2)
            .Sum();
}
}