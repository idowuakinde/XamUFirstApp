using Xamarin.Forms;

namespace XamUFirstApp
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = 
                { 
                    new Label { Text = "Congrats, Idowu. You did it! Xamarin Forms!", HorizontalTextAlignment = TextAlignment.Center }
                }
            };

            MainPage = new ContentPage
            {
                Content = layout
            };

            Button button = new Button
            {
                Text = "Click Me"
            };

            button.Clicked += async (s, e) => 
            { 
                await MainPage.DisplayAlert("Alert", "You clicked me", "Ok"); 
            };

            layout.Children.Add(button);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
