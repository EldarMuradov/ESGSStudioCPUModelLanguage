using CPU_Model_And_Assembler.App.Process.Commands.Base;
using System;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public sealed class SubtractCommand : BaseBinaryCommand
    {
        public SubtractCommand(int regNum) : base(regNum, "sub") { }

        protected override int ExecuteBinaryCommand(int left, int right) => left - right;
    }
}