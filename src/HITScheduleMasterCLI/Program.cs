using PlasticMetal.MobileSuit;

namespace HITScheduleMasterCLI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            (new MsHost(new Driver())).Run();

        }
        

    }
}
