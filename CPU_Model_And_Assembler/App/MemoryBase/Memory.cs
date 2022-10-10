using System;
using System.Collections.Generic;

namespace CPU_Model_And_Assembler.App.MemoryBase
{
    public static class Memory
    {
        private static readonly Dictionary<string, int> _ram = new();

        public static int Read(string adress) => _ram[adress];

        public static void Write(string adress, int value) => _ram[adress] = value;

        public static void Dump()
        {
            foreach (var (adress, val) in _ram)
                Console.Write($"{adress}={val}".PadLeft(5));
        }
    }
}