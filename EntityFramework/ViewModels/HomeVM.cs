using EntityFramework.Models;

namespace EntityFramework.ViewModels
{
    public class HomeVM
    {
        public List<Features> Features { get; set; }
        public List<Slider> Sliders { get; set; }

        public List<Projects> Projects { get; set; }

        public List<Services> Services { get; set; }
    }
}
