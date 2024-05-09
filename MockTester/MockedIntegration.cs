using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTester
{
    public record MockedIntegration
    {
        public string Name { get; set; }
        public string NewOrderSingle { get; set; }
        public string OrderCancelReplaceRequest {  get; set; }
        public string OrderCancelRequest { get; set; }
    }
}
