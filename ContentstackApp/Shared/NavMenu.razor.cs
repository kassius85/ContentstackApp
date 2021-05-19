using ContentstackApp.Content;
using ContentstackApp.Helpers;
using Microsoft.AspNetCore.Components;

namespace ContentstackApp.Shared
{
    public partial class NavMenu
    {
        [Parameter]
        public NavMenuParameters NavMenuParameters { get; set; }

        private bool collapseNavMenu = true;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
