using System.ComponentModel.DataAnnotations;

namespace OnlineBookRazorPagesApp.Model
{
    class Category{
        [Key]
        public int Id{get;set;}
        [Required]
        public string Name{get;set;}
         [Required]
        [ Range(1,100,ErrorMessage ="The range should be betweeen 1 to 100")]
        public int DisplayOrder{get;set;}

    }
}