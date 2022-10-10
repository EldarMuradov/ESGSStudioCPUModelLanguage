namespace CPU_Model_And_Assembler.App.Process
{
    public interface ICommand
    {
        void Execute(int[] registers, ref int currentCommandIndex);
        void Dump();
    }
}
