using DbManagerLibrary.Tables;
using System;
using System.Collections.Generic;
using WordWorkerLibrary.Interfaces;

namespace WordWorkerLibrary.DefaultWorkers
{
    class WordWorkerOffline : IWordWorkerOffline
    {
        public bool AddRangeOfWords(LinkedWord[] words, bool saveNow = false)
        {
            throw new NotImplementedException();
        }

        public bool AddWord(LinkedWord word, bool saveNow = false)
        {
            throw new NotImplementedException();
        }

        public void CashAllWords()
        {
            throw new NotImplementedException();
        }

        public List<LinkedWord> GetAvailableList(string language, bool saveList = false)
        {
            throw new NotImplementedException();
        }

        public string[] GetLanguageList()
        {
            throw new NotImplementedException();
        }

        public LinkedWord GetNext(bool random)
        {
            throw new NotImplementedException();
        }

        public LinkedWord GetTranslate(LinkedWord word)
        {
            throw new NotImplementedException();
        }
    }
}
