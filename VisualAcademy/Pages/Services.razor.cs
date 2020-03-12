using System;

namespace VisualAcademy.Pages
{
    public partial class Services
    {
        public string Title { get; set; } = "서비스";
        public string subTitle { get; set; } = DateTime.Now.ToShortTimeString();
        protected override void OnInitialized()
        {

        }
    }
}
