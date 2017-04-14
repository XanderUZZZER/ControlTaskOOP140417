using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTaskOOP140417
{
    public class FileInfo
    {
        public string Type { get; protected set; }
        public string Name { get; protected set; }
        public string Extension { get; protected set; }
        public string Size { get; protected set; }
        public string Content { get; protected set; }
        public string Resolution { get; protected set; }
        public string Length { get; protected set; }
    }
}
