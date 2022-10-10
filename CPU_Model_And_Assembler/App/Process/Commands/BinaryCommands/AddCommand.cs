using CPU_Model_And_Assembler.App.Process.Commands.Base;
using System;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public sealed class AddCommand : BaseBinaryCommand
    {
        public AddCommand(int regNum): base(regNum, "add") {}

        protected override int ExecuteBinaryCommand(int left, int right) => left + right;
    }
}