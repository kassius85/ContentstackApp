using ContentstackApp.Content;
using ContentstackApp.Helpers;
using ContentstackApp.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ContentstackApp.Shared
{
    public partial class MainLayout
    {
        [Inject]
        public ContenstackSettings ContenstackSettings { get; set; }

        [Inject]
        private IHeaderService HeaderService { get; set; }

        [Inject]
        private IMenuService MenuService { get; set; }

        private ResponseHeader ResponseHeader { get; set; }

        private NavMenuParameters MenuParameters { get; set; }

        private string Style { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // Get default header styles.
            Style = string.Format("color: {0}; background-color: {1};", ContenstackSettings.DefaultHeaderStyles.TextColor,
                                                                        ContenstackSettings.DefaultHeaderStyles.BackGroundColor);

            ResponseHeader = await HeaderService.GetHeaderDataAsync();

            // Get personalized styles.
            Style = string.Format("color: {0}; background-color: {1}; font-family: {2}; font-size: {3}px; font-weight: {4} !important; font-style: {5};",
                                    ResponseHeader.Header.TextColor,
                                    ResponseHeader.Header.BackgroundColor,
                                    ResponseHeader.Header.TextFont,
                                    ResponseHeader.Header.TextSize,
                                    ResponseHeader.Header.TextWeight,
                                    ResponseHeader.Header.TextStyle);

            ResponseMenu responseMenu = await MenuService.GetMenuDataAsync();

            // Get image and personalized styles.
            MenuParameters = new NavMenuParameters()
            {
                UrlImage = responseMenu.Menu.MenuImage.Url,
                NavMenuStyle = string.Format("background-color: {0};", responseMenu.Menu.BackgroundColor)
            };

            await base.OnInitializedAsync();
        }
    }
}
