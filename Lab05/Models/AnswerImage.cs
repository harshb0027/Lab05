using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab05.Models
{
    public class AnswerImage
    {

        [Key]
        public int AnswerId
        {
            get;
            set;
        }


        [Required]
        [Column("FileName")]
        [Display(Name = "File Name")]        
        public string FileName
        {
            get;
            set;
        }


        [Required]
        [Column("Url")]
        [Display(Name = "URL")]
        public string Url
        {
            get;
            set;
        }

        public enum Question
        {
            Earth, Computer
        }
    }
}
