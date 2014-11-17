using System;
using System.Collections.Generic;
using System.Text;
using SampleRoundedButtonForms.CustomControls;
using SampleRoundedButtonForms.ViewModels;
using Xamarin.Forms;

namespace SampleRoundedButtonForms.Views
{
    public class MainView : BaseView
    {
        #region Properties
        private MainViewModel ViewModel
        {
            get { return BindingContext as MainViewModel; }
        }
        #endregion

        #region Ctor
        public MainView()
        {
            this.BindingContext = new MainViewModel();

            RoundedButton rb = new RoundedButton
                {
					HorizontalOptions = LayoutOptions.Center,
                    Font = Font.SystemFontOfSize(NamedSize.Large),
                    Stroke = Color.FromHex("009fff"),
                    StrokeThickness = 5,
                    CornerRadius = 40,
                    FontSize = 30,
                };

            rb.SetBinding(RoundedButton.TextProperty, "BtnRoundedText");
            rb.SetBinding(RoundedButton.ColorBackgroundProperty, "BtnRoundedBackgroundColor");
            rb.SetBinding(RoundedButton.ColorTextProperty, "BtnRoundedTextColor");

            rb.Clicked += (s, e) =>
                {
                    ViewModel.RoundedCommand.Execute(0);
                };

            Button sb = new Button
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Font = Font.SystemFontOfSize(NamedSize.Large),
                };

            sb.SetBinding(Button.TextProperty, "BtnSimpleText");
            sb.SetBinding(Button.BackgroundColorProperty, "BtnSimpleBackgroundColor");
            sb.SetBinding(Button.TextColorProperty, "BtnSimpleTextColor");

            sb.Clicked += (s, e) =>
            {
                ViewModel.SimpleCommand.Execute(0);
            };

            StackLayout sl = new StackLayout
                {
                    Padding = new Thickness(0, 10),
                    Children = 
                    {
                        rb,
                        sb
                    }
                };

            this.Content = sl;
        }
        #endregion
    }
}