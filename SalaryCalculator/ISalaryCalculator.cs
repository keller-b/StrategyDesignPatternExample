using System.Collections;
using System.Collections.Generic;

namespace SOLID
{
    public interface ISalaryCalculator
    {
         double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }

}