using System;
using System.Collections.Generic;
using System.Text;

namespace CpuSim
{
    abstract public class CpuComponent
    {
        abstract public void Step();
        abstract public void Reset();
        abstract public void PrintState();
    }
}
