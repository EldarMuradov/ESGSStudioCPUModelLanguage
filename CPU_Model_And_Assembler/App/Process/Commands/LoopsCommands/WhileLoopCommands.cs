using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Model_And_Assembler.App.Process.Commands
{
    public class WhileLoopCommands
    {
        private readonly ICommand[] _condition, _body; 

        public WhileLoopCommands(ICommand[] condition, ICommand[] body)
        {
            _condition = condition;
            _body = body;
        }

        public IEnumerable<ICommand> Compile()
        {
            var body = _body.Concat(new ICommand[] 
            {
                new PutConstantRegisterCommand(0, int.MaxValue),
                new JumpCommand()
            }).ToArray();

            var ifCommandCount = new IfCommand(_condition, body, Array.Empty<ICommand>()).Compile().Count() - 3;

            body[^2] = new PutConstantRegisterCommand(0, -ifCommandCount);

            return new IfCommand(_condition, body, Array.Empty<ICommand>()).Compile();
        }
    }
}
