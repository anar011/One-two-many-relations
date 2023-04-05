namespace EntityFramework_Slider.Models
{
    public class About : BaseEntity
    {
        public string Image { get; set; } 

        public string Header { get; set; }
        public string Description { get; set; }
        public ICollection<AboutDesc> AboutDescs { get; set; }

    }
}
