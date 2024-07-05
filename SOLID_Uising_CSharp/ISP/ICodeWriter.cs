using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uising_CSharp.ISP
{
    //The Interface Segregation Principle states that a client should not be forced to implement interfaces it doesn’t use.


    //Consider an IWorker interface with methods for both developers and testers.

    public interface IWorker
    {
        void WriteCode();
        void TestCode();

    }
    //This could be problematic for a Manager class that doesn't need to implement both methods.

    public class Manager : IWorker
    {
        public void TestCode()
        {
            // manager can not test code
        }

        public void WriteCode()
        {
            // manager can not write code
        }
    }

    //To adhere to ISP, we can split the IWorker interface into two separate interfaces: ICodeWriter and ICodeTester.

    public interface ICodeWriter
    {
        void WriteCode();
    }

    public interface ICodeTester
    {
        void TestCode();
    }
}
