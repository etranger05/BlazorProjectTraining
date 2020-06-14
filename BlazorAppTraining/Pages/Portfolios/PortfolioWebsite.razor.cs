using Microsoft.AspNetCore.Components;

namespace BlazorAppTraining.Pages.Portfolios
{
    public partial class PortfolioWebsite : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManagerRef { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected void GotoMyProfile()
        {
            //NavigationManagerRef.NavigateTo("http://profile.tracywith.me");
            NavigationManagerRef.NavigateTo("/index");

        }
    }
}
