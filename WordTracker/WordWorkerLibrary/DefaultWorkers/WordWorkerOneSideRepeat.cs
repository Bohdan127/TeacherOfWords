using DbManagerLibrary.Interfaces;
using DbManagerLibrary.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using WordWorkerLibrary.Interfaces;

namespace WordWorkerLibrary.DefaultWorkers
{
    public class WordWorkerOneSideRepeat : IWordWorker
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private List<LinkedWord> savedList;
        private IRepository repo;
        private bool getCashedRecords;
        private bool needReCash;
        private bool offline;


        public IRepository CurrentRepo
        {
            get
            {
                log.Info("Get current Repo");
                if (repo == null)
                {
                    log.Error("Was try to get repo, but it is null!");
                    throw new ArgumentNullException();
                }
                log.Info("Repo type is " + repo.GetType().ToString());

                //todo add more checking
                //todo like checking for available DB or Internet connection
                return repo;
            }

            //todo add logs here
            set { repo = value; }
        }

        public bool GetCashedRecords
        {
            get
            {
                log.Info("Get GetCashedRecord, value " + getCashedRecords.ToString());
                return getCashedRecords;
            }

            set
            {
                log.Info("Set into GetCashedRecord value " + getCashedRecords.ToString());
                getCashedRecords = value;
            }
        }

        public bool WorksOffline
        {//todo add logs here
            get { return offline; }
            set { offline = value; }
        }

        public WordWorkerOneSideRepeat()
        {
            //todo restore here last words collection!!!
            //todo with no diff where is DB, it should be saved                                     
            savedList = new List<LinkedWord>();
            getCashedRecords = false;
        }


        public List<LinkedWord> GetAvailableList(string language, bool saveList = false)
        {//todo add logs here
            if (getCashedRecords)
            {
                if (needReCash)
                    CashAllWords();
                return savedList;
            }


            var resList = new List<LinkedWord>();

            resList.AddRange(repo.Select<LinkedWord>().Where(w => w.Language.Equals(language)));



            return resList;
        }

        public LinkedWord GetNext(bool random)
        {//todo add logs here
            var resWord = new LinkedWord();

            return resWord;
        }

        public LinkedWord GetTranslate(LinkedWord word)
        {//todo add logs here
            var resWord = new LinkedWord();

            return resWord;
        }

        public void CashAllWords()
        {//todo add logs here
            savedList.Clear();
            savedList.AddRange(repo.Select<LinkedWord>());
        }

        public string[] GetLanguageList()
        {
            throw new NotImplementedException();
        }
    }
}
