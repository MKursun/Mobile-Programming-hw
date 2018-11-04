using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace hw1
{
    public partial class App : Application
    {
        public App()
        {
            var tabbeled = new TabbedPage();
            tabbeled.Children.Add(new Hakkında());
            tabbeled.Children.Add(new Kisiler());
            tabbeled.Children.Add(new Altyapı());
            tabbeled.Children.Add(new Dersler());


            MainPage = tabbeled;
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
