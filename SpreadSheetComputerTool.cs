using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1_AspNetMVC_Dependency
{
    class SpreadSheetComputerTool : ITool
    {
        public SpreadSheetComputerTool()
        {

        }

        public void UseTool()
        {
            Console.WriteLine("The Spreadsheet is very useful to the company!");
        }
    }
}
