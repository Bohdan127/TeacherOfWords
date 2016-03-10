using DbManagerLibrary.Interfaces;
using DbManagerLibrary.Tables;
using System.Collections.Generic;

namespace WordWorkerLibrary.Interfaces
{
    public interface IWordWorker
    {
        IRepository CurrentRepo { get; set; }
        bool WorksOffline { get; set; }
        bool GetCashedRecords { get; set; }
        List<LinkedWord> GetAvailableList(string language, bool saveList = false);
        LinkedWord GetNext(bool random);
        LinkedWord GetTranslate(LinkedWord word);
        void CashAllWords();
        string[] GetLanguageList();
    }
}
