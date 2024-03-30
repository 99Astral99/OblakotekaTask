using System.ComponentModel.DataAnnotations;

namespace OblakotekaTask.Domain.ViewModels.ProductModels
{
    public class CreateProductViewModel
    {
        [Required(ErrorMessage = "Поле является обязательным")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

    }
}
