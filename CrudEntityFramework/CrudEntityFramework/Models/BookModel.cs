using System.ComponentModel.DataAnnotations;

namespace CrudEntityFramework.Models
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }
        public string Bookname { get; set; }
        public string Price { get; set; }
        public string Author { get; set; }

    }
}
