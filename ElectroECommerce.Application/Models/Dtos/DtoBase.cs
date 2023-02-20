namespace ElectroECommerce.Application.Models.Dtos
{
    public class DtoBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int Status { get; set; }
    }
}
