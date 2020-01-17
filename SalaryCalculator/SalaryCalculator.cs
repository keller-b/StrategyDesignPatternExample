using System.Collections.Generic;

namespace SOLID
{
    public class SalaryCalculator
    {
        //  The Context, injecting (D.I.) any object of type ISalaryCalculator in the constructor, or any class the implements ISalaryCalculator interface
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