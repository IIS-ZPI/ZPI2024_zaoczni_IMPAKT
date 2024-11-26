using IMPAKT.Settings;
using Microsoft.Extensions.Options;

namespace IMPAKT.Labs
{
    public class Lab1
    {
        private readonly MainSettings _mainSettings;

        public Lab1(IOptions<MainSettings> options)
        {
            _mainSettings = options.Value;
        }
        public void Execute()
        {
            Console.WriteLine("Nazwa grupy: Impakt. Scrum master: tirey93.");
            Console.WriteLine("DevOps Engineer: hubert-cywka");
            Console.WriteLine("Dev1: tirey93");
            Console.WriteLine("Dev2: lukasz-kkk");
            Console.WriteLine("Tester: BeastRacid");

        }
    }
}
