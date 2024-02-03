using System.ComponentModel.DataAnnotations;

namespace CoreProjectApi.DAL.ApiContext.Entity
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}
