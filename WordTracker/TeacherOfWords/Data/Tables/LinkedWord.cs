using SQLite;
using System.ComponentModel.DataAnnotations;

namespace TeacherOfWords.Data.Tables
{
    public class LinkedWord
    {
        [Required]
        [PrimaryKey]
        [Unique]
        [AutoIncrement]
        public long Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Word { get; set; }

        public long ParId { get; set; }

        [Required]
        [MaxLength(2)]
        public string Language { get; set; }

        public override string ToString()
        {
            return string.Format("LinkedWord: Id - '{0}'; Word - '{1}'; ParId - '{2}'; Language - '{3}';", Id, Word, ParId, Language);
        }
    }
}
