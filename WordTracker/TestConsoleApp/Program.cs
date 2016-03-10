using DbManagerLibrary.DefaultManagers.Repositories;
using DbManagerLibrary.Interfaces;
using WordWorkerLibrary.Interfaces;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository localRepo = new LocalRepository();
            //var list = localRepo.Select<LinkedWord>();
            //foreach (var item in list)
            //{
            //    Console.WriteLine("item " + item.Id + " " + item.ParId + " " + item.Word);
            //}
            IWordWorker worker = new WordWorkerLibrary.DefaultWorkers.WordWorkerOneSideRepeat();

            worker.CurrentRepo = localRepo;

            //worker.AddWord(new LinkedWord() { Language = "en", Word = "apple" });
            //worker.AddWord(new LinkedWord() { Language = "ua", Word = "яблуко" }, true);

            worker.GetAvailableList("en");

        }
    }
}
