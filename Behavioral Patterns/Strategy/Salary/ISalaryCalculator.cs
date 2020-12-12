using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Salary
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
