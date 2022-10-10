using System;
using CPU_Model_And_Assembler.App.MemoryBase;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public class ReadCommand : ICommand
    {
        private readonly int _regNum;
        private readonly string _adress;

        public ReadCommand(int regNum, string adress)
        {
            _regNum = regNum;
            _adress = adress;
        }

        public void Dump() => Console.Write($"r{_regNum} = {Memory.Read(_adress)} {_adress}");

        public void Execute(int[] registers, ref int currentCommandIndex)
        {
            registers[_regNum] = Memory.Read(_adress);
            currentCommandIndex++;
        }
    }
}