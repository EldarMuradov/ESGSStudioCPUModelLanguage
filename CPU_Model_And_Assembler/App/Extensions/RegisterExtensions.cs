using System;

namespace CPU_Model_And_Assembler.App.RegisterExtensions
{
    public static class RegisterExtensions
    {
        public static void Dump(this int[] registers) 
        {
            foreach (var item in registers)
                Console.Write($"{item, 3}");
        }
    }
}