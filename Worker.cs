using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lesson3_1_AspNetMVC_Dependency
{
    class Worker
    {
        private ShovelTool _shovel;
        
        public Worker()
        {
            _shovel = new ShovelTool();
        }

        public void UseShovel()
        {
            _shovel.UseTool();
        }
    }
}
