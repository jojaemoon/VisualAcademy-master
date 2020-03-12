using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualAcademy.Pages.Portfolios
{
    public partial class PortfolioWebsite
    {
        [Inject]
        public NavigationManager NavigationManager  { get; set; }

        protected override void OnInitialized()
        {
            
        }

        protected void GoToTrack()
        {
            //NavigationManager.NavigateTo("/Index");
            NavigationManager.NavigateTo("http://sportsall.kr/GBAAF_Home");
        }

    }
}
