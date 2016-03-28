using DbManagerLibrary.Interfaces;
using DbManagerLibrary.Tables;
using System;
using System.Windows.Forms;
using WordWorkerLibrary.Interfaces;

namespace WordWorkerLibrary.DefaultAdders
{
    public class WordAdderSimple : IWordAdder
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IRepository repo;
        private bool modified;
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
                //todo like checking for available DB or inthernet connection
                return repo;
            }


            set { repo = value; }
        }

        public bool WorksOffline
        {
            get { return offline; }
            set { offline = value; }
        }



        public bool AddNewWord(LinkedWord word, bool saveNow = false)
        {//todo add logs here
            bool bRes = true;

            try
            {
                repo.Insert(word, saveNow);
            }
            catch (Exception ex)
            {
                log.Error("Error when adding word: ");
                log.Error(word.ToString());
                log.Error(ex.Message);

                bRes = false;
            }

            return bRes;
        }

        public bool Save(bool user)//todo !!! move it to UWP, here just saving
        {//todo add logs here
            bool bRes = true;
            bool bSave = true;

            if (modified)
            {
                if (user)
                {
                    bSave = false;
                    var userChoice = MessageBox.Show("Save words?", "Exit", MessageBoxButtons.YesNoCancel);//todo we need to check if it will be works in UWP 
                                                                                                           //from stackoverflow:
                                                                                                           //var dialog = new MessageDialog("Your message here");
                                                                                                           //await dialog.ShowAsync();

                    switch (userChoice)
                    {
                        case DialogResult.Yes:
                            bSave = true;
                            break;
                        case DialogResult.No:
                            //todo should be nothing here but maybe later we need to check again
                            break;
                        default:
                            bRes = false;
                            break;
                    }
                }

                if (bSave)
                {
                    //todo check logic and finish changes
                    repo.Save();

                    //sometimes here bRes can be set to false;
                }
                if (bRes)
                {
                    modified = false;
                }
            }
            return bRes;
        }

        public bool AddNewWord(LinkedWord word1, LinkedWord word2, bool saveNow = false)
        {
            throw new NotImplementedException();
        }

        public bool AddManyWords(LinkedWord[] words, bool saveNow = false)
        {
            throw new NotImplementedException();
        }

        public bool AddManyWords(LinkedWord[] words1, LinkedWord[] words2, bool saveNow = false)
        {
            throw new NotImplementedException();
        }
    }
}
