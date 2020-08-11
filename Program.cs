using System;

namespace Lesson3_1_AspNetMVC_Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson 3_1!");

            Worker myWorker = new Worker();
            myWorker.UseShovel();

            FlexWorker officeWorker = new FlexWorker(new SpreadSheetComputerTool());
            officeWorker.DoSomeWork();

            FlexWorker plumber = new FlexWorker(new PipeCutterTool());
            plumber.DoSomeWork();

            FlexWorker leatherFace = new FlexWorker(new ChainSawTool());
            leatherFace.DoSomeWork();
        }
    }
}
