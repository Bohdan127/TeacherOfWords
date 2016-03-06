using System.ComponentModel.DataAnnotations;

namespace DbManagerLibrary.Tables
{
    public class LinkedWord
    {
        [Required]
        public long Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Word { get; set; }

        public long ParId { get; set; }

        [Required]
        [MaxLength(2)]
        public string Language { get; set; }
    }
}
