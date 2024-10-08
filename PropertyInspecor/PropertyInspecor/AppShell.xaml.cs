using PropertyInspecor.Views.Pages;
using SimpleToolkit.Core;
using SimpleToolkit.SimpleShell;

namespace PropertyInspecor;

public partial class AppShell : SimpleShell
{
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            AddTab(typeof(DashboardPage), PageType.DashboardPage);
            AddTab(typeof(ChecklistPage), PageType.ChecklistPage);
            AddTab(typeof(ImagesPage), PageType.ImagesPage);
            AddTab(typeof(AdminPage), PageType.AdminPage);

        Loaded += AppShellLoaded;
        }


        private static void AppShellLoaded(object sender, EventArgs e)
        {
            var shell = sender as AppShell;

        shell.Window.SubscribeToSafeAreaChanges(safeArea =>
        {
            shell.pageContainer.Margin = safeArea;
            shell.tabBarView.TabsPadding = new Thickness(safeArea.Left, 0, safeArea.Right, safeArea.Bottom);
        });
        }

        private void AddTab(Type page, PageType pageEnum)
        {
            var tab = new Tab { Route = pageEnum.ToString(), Title = pageEnum.ToString() };
            tab.Items.Add(new ShellContent { ContentTemplate = new DataTemplate(page) });

        tabBar.Items.Add(tab);
        }

        private void TabBarViewCurrentPageChanged(object sender, TabBarEventArgs e)
        {
            Shell.Current.GoToAsync("///" + e.CurrentPage.ToString());
        }
        }

        public enum PageType
        {
            DashboardPage, ChecklistPage, ImagesPage, AdminPage
        }

