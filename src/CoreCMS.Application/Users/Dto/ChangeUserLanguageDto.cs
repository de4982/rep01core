using System.ComponentModel.DataAnnotations;

namespace CoreCMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}