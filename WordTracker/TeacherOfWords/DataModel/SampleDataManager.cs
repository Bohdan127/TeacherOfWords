using SQLite;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TeacherOfWords.Data.Tables;
using Windows.UI.Xaml;

namespace TeacherOfWords.DataModel
{
    public sealed class SampleDataManager
    {
        public async static Task<ObservableCollection<ItemDescription>> GetDeaultItemList()
        {
            ObservableCollection<ItemDescription> resGroup =
                new ObservableCollection<ItemDescription>();

            var connection = new SQLiteAsyncConnection(
                Application.Current.Resources["DbPath"] as string);

            var itemList = connection.Table<ItemDescription>()
                .Where(item => item.UniqueId != -1).ToListAsync().Result;

            foreach (var item in itemList)
            {
                resGroup.Add(item);
            }

            return resGroup;
        }
    }

    public class ItemDescriptions : ObservableCollection<ItemDescription>
    {
        public ItemDescriptions()
        {
            foreach (var item in SampleDataManager.GetDeaultItemList().Result)
            {
                Add(item);
            }
        }

    }
}