using StrategyDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Concrete
{
    public class LenderInstitution
    {
        IDeptCalculating deptCalculating;
        public LenderInstitution(IDeptCalculating deptCalculating)
        {
            this.deptCalculating = deptCalculating;
        }

        public void CalculateDept()
        {
            deptCalculating.DeptCalculator();
        }
    }
}
