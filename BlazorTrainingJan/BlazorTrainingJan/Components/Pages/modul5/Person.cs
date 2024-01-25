using System.ComponentModel.DataAnnotations;

namespace BlazorTrainingJan.Components.Pages.modul5
{
    public class Person
    {
        [Required(ErrorMessage ="bitte füllen")]
        [StringLength(10,ErrorMessage ="maximal 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "bitte füllen")]     
        [Range(150,190,ErrorMessage ="zwischen {0} und {1}")]
        public int Gross { get; set; }

        [Required(ErrorMessage = "bitte füllen")]
        public DateTime? GebDate { get; set; }
    }
}
