using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uising_CSharp.SRP
{
    public class ReportGenerators // this class are responsible for both method
    {
        public void GenerateReport()
        {

        }

        public void FormatReport()
        {

        }
    }

    //The Single Responsibility Principle states that a class should have only one reason to change,
    //meaning it should have only one job or responsibility.

    public class ReportGenerator // one job
    {
        public void GenerateReport()
        {

        }
    }

    public class ReportFormatter // one job
    {
        public void FormatReport()
        {

        }
    }
}
