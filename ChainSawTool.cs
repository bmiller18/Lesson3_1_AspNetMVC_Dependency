using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1_AspNetMVC_Dependency
{
    class ChainSawTool : ITool
    {
        public ChainSawTool()
        {

        }
        public void UseTool()
        {
            Console.WriteLine("The chainsaw tool is put to use.");
        }
    }
}
