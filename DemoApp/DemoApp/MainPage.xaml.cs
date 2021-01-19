using System;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        const uint AnimationSpeed = 300;
        private void Button_Clicked(object sender, EventArgs e)
        {
            var pageHeight = RootPage.Height;
            PageFader.IsVisible = true;
            PageFader.FadeTo(.6, AnimationSpeed, Easing.SinInOut);
            DetailsView.TranslateTo(0, pageHeight * .1, AnimationSpeed, Easing.SinInOut);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await DetailsView.TranslateTo(0, Height, AnimationSpeed, Easing.SinInOut);
            await DetailsView.TranslateTo(0, Height, AnimationSpeed, Easing.SinInOut);
            await PageFader.FadeTo(0, AnimationSpeed, Easing.SinInOut);
            PageFader.IsVisible = false;
        }
    }
}
