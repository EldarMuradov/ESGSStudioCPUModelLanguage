using System;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public class OutputCommand : ICommand
    {
        private readonly string _outputText;

        public OutputCommand(string outputText) => _outputText = outputText;

        public void Dump() => Console.Write("out");

        public void Execute(int[] registers, ref int currentCommandIndex) 
        {
            Console.Write(_outputText);
            currentCommandIndex++;
        } 
        
    }
}