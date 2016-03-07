using DbManagerLibrary.Interfaces;
using DbManagerLibrary.Tables;
using System.Collections.Generic;

namespace WordWorkerLibrary.Interfaces
{
    public interface IWordWorker
    {
        IRepository CurrentRepo { get; set; }

        List<LinkedWord> GetAvailableList(string language, bool saveList = false);

        LinkedWord GetNext(bool random);

        LinkedWord GetTranslate(LinkedWord word);

        void CashAllWords();

        bool GetCashedRecords { get; set; }

        bool AddWord(LinkedWord word, bool saveNow = false);

        bool AddRangeOfWords(LinkedWord[] words, bool saveNow = false);

        bool Save(bool user);

        string[] GetLanguageList();
    }
}
