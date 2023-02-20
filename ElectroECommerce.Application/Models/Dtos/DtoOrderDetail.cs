namespace ElectroECommerce.Application.Models.Dtos
{
    public class DtoOrderDetail : DtoBase
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Product navigation property
        /// </summary>
        public DtoProduct Product { get; set; }
    }
}
