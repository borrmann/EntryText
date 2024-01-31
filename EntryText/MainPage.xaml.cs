namespace EntryText
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            await Task.Delay(2000);
            E_RedText.Text = "I must be red";

        }
    }

}
