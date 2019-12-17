using System;
using System.Collections.Generic;
using System.Text;

namespace CpuSim
{
    public class RomComponent : IPeripheralBus
    {
        public uint DataWidth { get; private set; }
        public uint AddressWidth { get; private set; }

        private uint[] RomData;

        public RomComponent(uint addressWidth, uint dataWidth, uint romSize)
        {
            DataWidth = dataWidth;
            AddressWidth = addressWidth;

            RomData = new uint[romSize];
        }

        public void LoadData(uint[] data, int baseAddress = 0)
        {
            data.CopyTo(RomData, baseAddress);
        }

        public void BusWrite(uint address, uint data) { }

        public uint BusRead(uint address)
        {
            return RomData[address];
        }
    }
}
