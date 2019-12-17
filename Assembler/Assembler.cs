using System;
using System.Collections.Generic;

namespace Assembler
{
    public class Assembler
    {
        public static string Log { get; private set; }

        public static uint[] AssembleSource(string source)
        {
            Dictionary<string, uint> labels = new Dictionary<string, uint>();
            Dictionary<uint, string> labelReferences = new Dictionary<uint, string>();

            string[] sourceLines = source.Split('\n');

            Log = "";

            for (int lineNumber = 0; lineNumber++; lineNumber < sourceLines.Length)
            {
                string line = sourceLines[lineNumber].Trim();

                
            }

        }
    }
}
