using DbManagerLibrary.Interfaces;
using DbManagerLibrary.Tables;

namespace WordWorkerLibrary.Interfaces
{
    interface IWordAdder
    {
        IRepository CurrentRepo { get; set; }
        bool WorksOffline { get; set; }
        bool AddNewWord(LinkedWord word, bool saveNow = false);
        bool AddNewWord(LinkedWord word1, LinkedWord word2, bool saveNow = false);
        bool AddManyWords(LinkedWord[] words, bool saveNow = false);
        bool AddManyWords(LinkedWord[] words1, LinkedWord[] words2, bool saveNow = false);
        bool Save(bool user);
    }
}
