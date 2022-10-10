using System;
using System.Collections.Generic;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public class IncrementCommand
    {
        private readonly string _adress;

        public IncrementCommand(string adress) => _adress = adress;

        public IEnumerable<ICommand> Compile() 
        {
            yield return new ReadCommand(0, _adress);
            yield return new PutConstantRegisterCommand(1, 1);
            yield return new AddCommand(0);
            yield return new WriteCommand(0, _adress);
        }
    }
}