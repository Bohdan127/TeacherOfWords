using DbManagerLibrary.Tables;

namespace WordWorkerLibrary.Interfaces
{
    public interface IWordAdderOffline
    {
        bool AddNewWord(LinkedWord word, bool saveNow = false);
        bool AddNewWord(LinkedWord word1, LinkedWord word2, bool saveNow = false);
        bool AddManyWords(LinkedWord[] words, bool saveNow = false);
        bool AddManyWords(LinkedWord[] words1, LinkedWord[] words2, bool saveNow = false);
        bool Save(bool user);
    }
}
