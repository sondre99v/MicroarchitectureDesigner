using System;
using CpuSim;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCpu cpu = new TestCpu();
            RomComponent rom = new RomComponent(8, 8, 256);
            rom.LoadData(new uint[] { 42, 69, 76, 123 });

            cpu.RomBus = rom;

            cpu.Reset();

            ConsoleKeyInfo key;
            do
            {
                cpu.PrintState();
                cpu.Step();
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
