using System.Collections.ObjectModel;

namespace TeacherOfWords.DataModel
{
    public sealed class SampleDataManager
    {
        public static ObservableCollection<SampleDataItem> GetDeaultItemList()
        {
            ObservableCollection<SampleDataItem> resGroup = new ObservableCollection<SampleDataItem>();

            var item = new SampleDataItem()
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

    public class SampleDataItems : ObservableCollection<SampleDataItem>
    {
        public SampleDataItems()
        {
            foreach (var item in SampleDataManager.GetDeaultItemList())
            {
                Add(item);
            }
        }
    }
}