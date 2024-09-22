

namespace To_DoListApp
{
    public partial class MainPage : ContentPage
    {
        int taskId = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void AddNewTask(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new TaskCreationPage());
        }
    }

}
