using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SearchEngine.Models
{

    public partial class User
    {
        public int UserID { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }

        public string LoginErrorMessage { get; set; }
        
    }
}