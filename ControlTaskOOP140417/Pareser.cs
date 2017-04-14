using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTaskOOP140417
{
    class Parser
    {
        public string[] temp;

        public Parser()
        {
        }

        public void GetObjects(string inputString)
        {
            int count = 0, index = 0;
            while (index < inputString.Length)
            {
                index = inputString.IndexOf('\n', index);
                count++;
            }
            temp = new string[count];
            

        }
    }
}
