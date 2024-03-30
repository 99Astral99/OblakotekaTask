using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OblakotekaTask.Domain.ViewModels.ProductModels
{
    public class ProductViewModel
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Поле является обязательным")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}
