using Microsoft.AspNetCore.Components;
using System;

namespace BlazorApp.Pages
{
    public partial class About : ComponentBase
    {
        private string title = "About Razor";
        private string subtitle = "SubTitle Razor";

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Subtitle = DateTime.Now.ToShortTimeString();
        }

    }
}
