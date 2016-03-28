using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TeacherOfWords.Data.Tables;

namespace TeacherOfWords.DataModel
{
    public sealed class SampleDataManager
    {
        public async static Task<ObservableCollection<ItemDescription>> GetDeaultItemList()
        {
            ObservableCollection<ItemDescription> resGroup = new ObservableCollection<ItemDescription>();

            //var connection = new SQLiteAsyncConnection(Application.Current.Resources["DbPath"] as string);

            //var resList = await connection.GetAsync<ItemDescription>(item => item != null);

            var item = new ItemDescription()
            {
                UniqueId = 1,
                Title = "Some First Title",
                Description = "New DescriptionNew DescriptionNew DescriptionNew DescriptionNew DescriptionNew DescriptionNew DescriptionNew DescriptionNew DescriptionNew DescriptionNew DescriptionNew Description",
                ImagePath = "Assets/SplashScreen.scale-100.png"
            };

            resGroup.Add(item);
            resGroup.Add(item);
            resGroup.Add(item);
            resGroup.Add(item);
            resGroup.Add(item);




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