using System;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public sealed class PutConstantRegisterCommand : ICommand
    {
        private readonly int _registerNum, _constant;

        public PutConstantRegisterCommand(int num, int constant)
        {
            _registerNum = num;
            _constant = constant;
        }

        public void Dump() => Console.Write($"put r{_registerNum} n{_constant}");

        public void Execute(int[] registers, ref int currentCommandIndex)
        {
            registers[_registerNum] = _constant;
            currentCommandIndex++;
        }
    }
}