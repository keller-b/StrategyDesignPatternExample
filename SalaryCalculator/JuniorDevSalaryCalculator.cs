using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    public class JuniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports)
        {
            return reports.Where(r => r.Level ==DeveloperLevelEnum.Junior)
                .Select(r => r.CalculateSalary())
                .Sum();
        }
    }
}