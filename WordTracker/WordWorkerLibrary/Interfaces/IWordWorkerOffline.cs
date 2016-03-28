using DbManagerLibrary.Tables;
using System.Collections.Generic;

namespace WordWorkerLibrary.Interfaces
{
    public interface IWordWorkerOffline
    {
        List<LinkedWord> GetAvailableList(string language, bool saveList = false);
        LinkedWord GetNext(bool random);
        LinkedWord GetTranslate(LinkedWord word);
        void CashAllWords();
        string[] GetLanguageList();
    }
}
