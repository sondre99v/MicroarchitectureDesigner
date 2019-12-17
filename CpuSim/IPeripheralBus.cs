using System;
using System.Collections.Generic;
using System.Text;

namespace CpuSim
{
    public interface IPeripheralBus
    {
        uint DataWidth { get; }
        uint AddressWidth { get; }

        void BusWrite(uint address, uint data);

        uint BusRead(uint address);
    }
}
