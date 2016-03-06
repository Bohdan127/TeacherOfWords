using DbManagerLibrary.DefaultManagers.Repositories;
using DbManagerLibrary.Tables;
using System;
using WordWorkerLibrary.Interfaces;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //LocalRepository localRepo = new LocalRepository();
            //var list = localRepo.Select<LinkedWord>();
            //foreach (var item in list)
            //{
            //    Console.WriteLine("item " + item.Id + " " + item.ParId + " " + item.Word);
            //}
            IWordWorker worker = new WordWorkerLibrary.DefaultWorkers.();
        }
    }
}
