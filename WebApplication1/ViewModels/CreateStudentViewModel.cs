using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.ViewModels
{
    public class CreateStudentViewModel
    {
        [DisplayName ("學號")]
        [Required]
        public string? Id { get; set; }

        [DisplayName("名字")]
        public string? Name { get; set; }

        [DisplayName("電話")]
        public string? Phone { get; set; }

        [DisplayName("帳號")]
        [EmailAddress]
        public string? Account { get; set; }

        [DisplayName("密碼")]
        public string? Password { get; set;}

        [DisplayName("地址")]
        public string? Address { get; set;}
    
    }
}
