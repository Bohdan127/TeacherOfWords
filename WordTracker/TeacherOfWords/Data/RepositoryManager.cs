using SQLite;
using System.Threading.Tasks;
using TeacherOfWords.Data.Tables;
using Windows.UI.Xaml;
using Version = TeacherOfWords.Data.Tables.Version;

namespace TeacherOfWords.Data
{
    public class RepositoryManager
    {
        private SQLiteAsyncConnection connection;

        public SQLiteAsyncConnection Connection
        {
            get { return connection; }
        }

        public RepositoryManager()
        {
            connection = new SQLiteAsyncConnection(Application.Current.Resources["DbPath"] as string);
        }

        #region Table Creation
        public async Task<bool> CreateAllTables()
        {
            bool bRes = true;

            bRes &= await CreateTable<LinkedWord>();
            bRes &= await CreateTable<Version>();
            bRes &= await CreateTable<ItemDescription>();
            //we should handle False result in app and show some scenario for it !!!
            return bRes;
        }

        protected virtual async Task<bool> CreateTable<T>()
             where T : new()
        {
            bool bRes = false;

            var result = await connection.CreateTableAsync<T>();

            bool? isResult = result?.Results?.ContainsKey(typeof(T));

            if (isResult != null && isResult.Value)
            {
                bRes = result.Results[typeof(T)] == (int)SQLite3.Result.OK;
            }

            return bRes;
        }
        #endregion

        #region Module Registration
        public async Task RegisterAllModules()
        {
            await RegisterOneWayModule();
        }

        /// <summary>
        /// Register One Way Module with UniqueId Equals to 1
        /// </summary>
        /// <returns></returns>
        public async Task RegisterOneWayModule()
        {
            var oneWayModule = await connection.GetAsync<ItemDescription>(item => item.UniqueId == 1);
            if (oneWayModule == null)
            {
                await connection.InsertAsync(new ItemDescription()
                {
                    ImagePath = "Assets/SplashScreen.scale-100.png",
                    Title = "One Way Translation",
                    Description = "Translation selected words only from" +
                    "one selected language to another with repeating each by 3 times.",
                    UniqueId = 1
                });
            }
        }
        #endregion
    }
}
