namespace To_DoListApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            App.Current.UserAppTheme = AppTheme.Light;
            MainPage = new NavigationPage(new MainPage());
            MainPage = new AppShell();
        }
    }
}
