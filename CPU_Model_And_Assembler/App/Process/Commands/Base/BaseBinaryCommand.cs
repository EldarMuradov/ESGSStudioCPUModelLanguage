using System;

namespace CPU_Model_And_Assembler.App.Process.Commands.Base
{
    public abstract class BaseBinaryCommand : ICommand
    {
        private readonly int _regNumber;
        private readonly string _command;

        public BaseBinaryCommand(int regNum, string command)
        {
            _regNumber = regNum;
            _command = command;
        }

        public void Dump() => Console.Write($"{_command} r{_regNumber}");

        public void Execute(int[] registers, ref int currentCommandIndex)
        {
            registers[_regNumber] = ExecuteBinaryCommand(registers[0], registers[1]);
            currentCommandIndex++;
        }

        protected abstract int ExecuteBinaryCommand(int left, int right);
    }
}