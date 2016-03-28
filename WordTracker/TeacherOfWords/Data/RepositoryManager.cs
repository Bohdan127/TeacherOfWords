using SQLite;
using System;
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

        public async Task<bool> CreateAllTables()
        {
            bool bRes = false;

            bRes &= await CreateLinkedWordTable();
            bRes &= await CreateVersionTable();
            bRes &= await CreateItemDescriptionTable();
            //we should handle False result in app and show some scenario for it !!!
            return bRes;
        }


        public async Task<bool> CreateLinkedWordTable()
        {
            bool bRes = false;

            var result = await connection.CreateTableAsync<LinkedWord>();

            bool? isResult = result?.Results?.ContainsKey(typeof(LinkedWord));

            if (isResult != null && isResult.Value)
            {
                bRes = result.Results[typeof(LinkedWord)] == (int)SQLite3.Result.OK;
            }

            return bRes;
        }

        public async Task<bool> CreateVersionTable()
        {
            bool bRes = false;

            var result = await connection.CreateTableAsync<Version>();

            bool? isResult = result?.Results?.ContainsKey(typeof(Version));

            if (isResult != null && isResult.Value)
            {
                bRes = result.Results[typeof(Version)] == (int)SQLite3.Result.OK;
            }

            return bRes;
        }

        public async Task<bool> CreateItemDescriptionTable()
        {
            bool bRes = false;

            var result = await connection.CreateTableAsync<ItemDescription>();

            bool? isResult = result?.Results?.ContainsKey(typeof(ItemDescription));

            if (isResult != null && isResult.Value)
            {
                bRes = result.Results[typeof(ItemDescription)] == (int)SQLite3.Result.OK;
            }

            return bRes;
        }

        protected virtual async Task<bool> CreateTable(Type table)//todo ?????????????????
        {
            bool bRes = false;

            var result = await connection.CreateTableAsync<LinkedWord>();

            bool? isResult = result?.Results?.ContainsKey(typeof(LinkedWord));

            if (isResult != null && isResult.Value)
            {
                bRes = result.Results[typeof(LinkedWord)] == (int)SQLite3.Result.OK;
            }

            return bRes;
        }
    }
}
