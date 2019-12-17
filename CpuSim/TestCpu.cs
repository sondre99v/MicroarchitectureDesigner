using System;
using System.Collections.Generic;
using System.Text;

namespace CpuSim
{
    public class TestCpu : CpuComponent
    {
        public IPeripheralBus RomBus { get; set; }

        public uint ProgramCounter { get; private set; }
        public uint Instruction { get; private set; }

        public TestCpu()
        {

        }

        public override void Reset()
        {
            ProgramCounter = 0;
            Instruction = 0;
        }

        public override void Step()
        {
            Instruction = RomBus.BusRead(ProgramCounter);
            ProgramCounter++;

            if(Instruction == 123)
            {
                ProgramCounter = 0;
            }
        }

        public override void PrintState()
        {
            Console.WriteLine("---");
            Console.WriteLine($"PC  = {ProgramCounter}");
            Console.WriteLine($"INS = {Instruction}");
        }
    }
}
