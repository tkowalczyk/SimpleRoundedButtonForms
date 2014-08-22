using SampleRoundedButtonForms.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SampleRoundedButtonForms
{
	public class App
	{
		public static Page GetMainPage()
		{
			return new ContentPage
			{
				Content = new RoundedButton 
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    Font = Font.SystemFontOfSize(NamedSize.Large),
                    ColorText = Color.FromHex("000000"),
                    ColorBackground = Color.FromHex("ffffff"),
                    Stroke = Color.FromHex("d91a17"),
                    StrokeThickness = 5,
                    CornerRadius = 40,
                    FontSize = 20,
                    Text = "Rounded Button",
				},
			};
		}
	}
}