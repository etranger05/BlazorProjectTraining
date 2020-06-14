using Microsoft.AspNetCore.Components;

namespace BlazorAppTraining.Pages
{
    public partial class Services : ComponentBase
    {
        private string title { get; set; } = "Services Title";

        
        private string subtitle = "Services Subtitle";

        public string SubTitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

        }
    }
}
