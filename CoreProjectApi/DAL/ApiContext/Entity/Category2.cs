using System.ComponentModel.DataAnnotations;

namespace CoreProjectApi.DAL.ApiContext.Entity
{
    public class Category2
    {
        [Key]
        public int Category2ID { get; set; }
        public string Category2Name { get; set; }
    }
}
