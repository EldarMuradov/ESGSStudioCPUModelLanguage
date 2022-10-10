using CPU_Model_And_Assembler.App.Process.Commands.Base;
using System;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public sealed class LessCommand : BaseBinaryCommand
    {
        public LessCommand(int regNum) : base(regNum, "ls") { }

        protected override int ExecuteBinaryCommand(int left, int right) => Convert.ToInt32(left < right);
    }
}