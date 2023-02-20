namespace ElectroECommerce.Domain
{
    public class Promotion : BaseEntity
    {
        public string PromotionName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

        public virtual ICollection<PromotionDetail> PromotionDetails { get; set; }  

    }
}
