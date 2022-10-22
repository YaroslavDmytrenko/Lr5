namespace First
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
            print.Print("Test_1");
            ExtendsPrinter extPrint = new ExtendsPrinter();
            extPrint.Print("Test_2");
        }

    }
}