using System.Collections.Generic;

namespace SOLID
{
    public class SalaryCalculator
    {
        private ISalaryCalculator _calculator;
    
        public SalaryCalculator(ISalaryCalculator calculator)
        {
            _calculator = calculator;
        }
    
        public void SetCalculator(ISalaryCalculator calculator) {
             _calculator = calculator;
        }
    
        public double Calculate(IEnumerable<DeveloperReport> reports){
            return _calculator.CalculateTotalSalary(reports);
        }
    }
}