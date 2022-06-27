using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FreeSpace.Models
{
    public class CustomizedDriveInfo
    {
        public string Name { get; set; }
        public decimal Total { get; private set; }
        public decimal Free { get; private set; }
        public decimal PercentUsed { get; private set; }
        public DriveType DriveType { get; private set; }
        public bool Available { get; private set; }
    }
}
