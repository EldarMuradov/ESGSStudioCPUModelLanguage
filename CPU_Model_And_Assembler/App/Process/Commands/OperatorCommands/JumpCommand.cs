using System;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public class JumpCommand : ICommand
    {
        public void Dump() => Console.Write("jmp");
        
        public void Execute(int[] registers, ref int currentCommandIndex) => currentCommandIndex += registers[0];
    }
}