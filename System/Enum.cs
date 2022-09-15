using System;
using System.Collections.Generic;
using System.Text;

namespace TheGameLauncher
{
    class Enum
    {

        public enum  StateOfApp
        {
            Stop =0,
            InProgress=1,
            Start=2
        }

        public enum Platform
        {
            Gog,
            Steam,
            Epic,
            Ubisoft,
            Origin,
            Microsoft
        }
    }
}
