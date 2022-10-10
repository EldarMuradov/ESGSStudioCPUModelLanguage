using CPU_Model_And_Assembler.App.Process;
using CPU_Model_And_Assembler.App.MemoryBase;
using CPU_Model_And_Assembler.App.Process.Commands;
using CPU_Model_And_Assembler.App.RegisterExtensions;
using System;
using System.Linq;

namespace CPU_Model_And_Assembler
{
    public sealed class Program
    {
        static void Main(string[] args)
        {
            int[] registers = new int[2];

            var condition = new ICommand[]
            {
                new PutConstantRegisterCommand(0, 10),
                new PutConstantRegisterCommand(1, 40),
                new LessCommand(0)
            };

            var declaration = new ICommand[]
            {
                new PutConstantRegisterCommand(0, 0),
                new WriteCommand(0, "i")
            };

            var loopCondition = new ICommand[]
            {
                new PutConstantRegisterCommand(1, 10),
                new ReadCommand(0, "i"),
                new LessCommand(0)
            };

            var body = new ICommand[]
            {
                new OutputCommand("loop")
            }.Concat(new IncrementCommand("i").Compile()).ToArray();

            var ifClause = new ICommand[]
            {
                new OutputCommand("true")
            };

            var elseClause = new ICommand[]
            {
                new OutputCommand("false")
            };

            var condCommands = new IfCommand(condition, ifClause, elseClause).Compile().ToArray();

            var loopCommands = declaration.Concat(new WhileLoopCommands(loopCondition, body).Compile()).ToArray();

            var commands = new ICommand[] 
            {
                new PutConstantRegisterCommand(0, 50), 
                new PutConstantRegisterCommand(1, 40),
                new AddCommand(0),
                new WriteCommand(0, "a"),
                new PutConstantRegisterCommand(0, 20),
                new PutConstantRegisterCommand(1, 30),
                new AddCommand(1),
                new WriteCommand(0, "a"),
                new GreaterCommand(0)
            };

            for (int i = 0; i < loopCommands.Length;)
            {
                Console.Write($"[{i.ToString().PadLeft(3, '0')}]-");
                var currentCommand = loopCommands[i];
                currentCommand.Dump();
                Console.CursorLeft = 40;
                currentCommand.Execute(registers, ref i);
                Console.CursorLeft = 20;
                registers.Dump();
                Console.CursorLeft = 30;
                Memory.Dump();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}