using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTester
{
    public record FixSessionConfig
    {
        public string Name { get; set; }
        public string SenderCompId { get; set; }
        public string TargetCompId { get; set; }
        public string RawData { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
    }
}
