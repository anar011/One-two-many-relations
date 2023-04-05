﻿using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public About Abouts { get; set; }

        public Expert Experts { get; set; }

        public SliderInfo SliderInfo { get; set; }

       
    }
}
