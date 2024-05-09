using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MockTester
{
    public static class Examples
    {
        public static FixSessionConfig[] GetFixSessions()
        {
            return new FixSessionConfig[]
            {
                new FixSessionConfig { Name = "Session1", SenderCompId = "Sender1", TargetCompId = "Target1", RawData = "RawData1", IP = "192.168.1.1", Port = 1234 },
                new FixSessionConfig { Name = "Session2", SenderCompId = "Sender2", TargetCompId = "Target2", RawData = "RawData2", IP = "192.168.1.2", Port = 5678 }
            };
        }
        public static MockedIntegration[] GetFixMessage()
        {
            return new MockedIntegration[]
            {
                new MockedIntegration
                {
                    Name = "Integration1",
                    NewOrderSingle = "8=FIX.4.4|35=D|55=IBM|54=1|38=100|40=1|",
                    OrderCancelReplaceRequest = "8=FIX.4.4|35=G|11=123|55=IBM|54=1|38=100|40=2|",
                    OrderCancelRequest = "8=FIX.4.4|35=F|11=456|55=IBM|54=1|38=100|40=4|"
                },
                new MockedIntegration
                {
                    Name = "Integration2",
                    NewOrderSingle = "8=FIX.4.4|35=D|55=AAPL|54=2|38=200|40=1|",
                    OrderCancelReplaceRequest = "8=FIX.4.4|35=G|11=789|55=AAPL|54=2|38=200|40=2|",
                    OrderCancelRequest = "8=FIX.4.4|35=F|11=987|55=AAPL|54=2|38=200|40=4|"
                }
            };
        }


    }
}
