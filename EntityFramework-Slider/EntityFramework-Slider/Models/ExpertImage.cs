namespace EntityFramework_Slider.Models
{
    public class ExpertImage:BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }
    }
}
