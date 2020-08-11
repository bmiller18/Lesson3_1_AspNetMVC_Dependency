using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1_AspNetMVC_Dependency
{
    class PipeCutterTool : ITool
    {
        public PipeCutterTool()
        {

        }
        public void UseTool()
        {
            Console.WriteLine("The Pipecutter tool cuts the pipe!");
        }
    }
}
