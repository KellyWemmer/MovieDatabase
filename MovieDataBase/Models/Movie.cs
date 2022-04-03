using System.ComponentModel.DataAnnotations;

namespace MovieDataBase.Models
{
    public class Movie
    {
        //Key is an attribute tells us we marked "ID" as primary key
        [Key]
        //Column names on movie table
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
