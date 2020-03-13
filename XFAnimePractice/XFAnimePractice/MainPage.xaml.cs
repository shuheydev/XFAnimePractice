using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFAnimePractice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void translateButton_Clicked(object sender, EventArgs e)
        {
            await translateButton.TranslateTo(100, 0, 500, Easing.BounceOut);
            await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);
            //await translateButton.TranslateTo(100, 0, 500, Easing.BounceIn);
            //await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);
            //await translateButton.TranslateTo(100, 0, 500, Easing.CubicIn);
            //await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);
            //await translateButton.TranslateTo(100, 0, 500, Easing.CubicInOut);
            //await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);
            //await translateButton.TranslateTo(100, 0, 500, Easing.Linear);
            //await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);
            //await translateButton.TranslateTo(100, 0, 500, Easing.SinIn);
            //await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);
            //await translateButton.TranslateTo(100, 0, 500, Easing.SinOut);
            //await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);
            //await translateButton.TranslateTo(100, 0, 500, Easing.SpringIn);
            //await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);
            //await translateButton.TranslateTo(100, 0, 500, Easing.SpringOut);
            //await translateButton.TranslateTo(0, 0);
            //await Task.Delay(1000);

        }

        private async void scaleButton_Clicked(object sender, EventArgs e)
        {
            await scaleButton.ScaleTo(3, 1000);
            await scaleButton.ScaleTo(1, 1000, Easing.SpringOut);
        }

        private async void rotateButton_Clicked(object sender, EventArgs e)
        {
            await Task.WhenAll(
                rotateButton.RotateTo(360, 1000),
                rotateButton.RotateXTo(360, 1000),
                rotateButton.RotateYTo(360, 1000)
            );

            rotateButton.Rotation = 0;
            rotateButton.RotationX = 0;
            rotateButton.RotationY = 0;



            //await rotateButton.RotateTo(100);
            //await rotateButton.RotateTo(0, 500, Easing.SpringOut);
            //await rotateButton.RotateXTo(360, 1000, Easing.SpringOut);
            //await rotateButton.RotateXTo(0);
        }

        private async void fadeButton_Clicked(object sender, EventArgs e)
        {
            //await fadeButton.RotateTo(360, 500, Easing.SpringOut);
            //await scaleButton.ScaleTo(1.1, 200);
            //await scaleButton.ScaleTo(1, 200, Easing.SpringOut);
            //await translateButton.TranslateTo(100, 0, 500, Easing.SpringIn);



            await fadeButton.FadeTo(0, 1000, Easing.SinInOut);
            await fadeButton.FadeTo(1, 0);
        }

        private async void rotateAnchorButton_Clicked(object sender, EventArgs e)
        {
            await rotateAnchorButton.RotateTo(360, 4000);
            rotateAnchorButton.Rotation = 0;
        }
    }
}
