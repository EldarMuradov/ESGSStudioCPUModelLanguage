using System;
using CPU_Model_And_Assembler.App.MemoryBase;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public class WriteCommand : ICommand
    {
        private readonly int _regNum;
        private readonly string _adress;

        public WriteCommand(int regNum, string adress)
        {
            _regNum = regNum;
            _adress = adress;
        }

        public void Dump() => Console.Write($"r{_adress} = r{_regNum}");

        public void Execute(int[] registers, ref int currentCommandIndex)
        {
            Memory.Write(_adress, registers[_regNum]);
            currentCommandIndex++;
        }
    }
}