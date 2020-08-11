using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3_1_AspNetMVC_Dependency
{
    class ShovelTool
    {
        #region Constructors
        public ShovelTool()
        {

        }
        #endregion

        #region Methods
        public void UseTool()
        {
            Console.WriteLine("Use the Shovel and do some Digging.");
        }
        #endregion
    }
}
