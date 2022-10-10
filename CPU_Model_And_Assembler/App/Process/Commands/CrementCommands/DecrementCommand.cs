using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public class DecrementCommand
    {
        private readonly string _adress;

        public DecrementCommand(string adress) => _adress = adress;

        public IEnumerable<ICommand> Compile()
        {
            yield return new ReadCommand(0, _adress);
            yield return new PutConstantRegisterCommand(1, 1);
            yield return new SubtractCommand(0);
            yield return new WriteCommand(0, _adress);
        }
    }
}
