using SQLite;
using System.ComponentModel.DataAnnotations;

namespace TeacherOfWords.Data.Tables
{
    public class ItemDescription
    {

        public string ImagePath { get; set; }

        [NotNull]
        public string Description { get; set; }

        [NotNull]
        public string Title { get; set; }

        [PrimaryKey]
        [Unique]
        [Required]
        public long UniqueId { get; set; }
    }
}
