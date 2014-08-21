using Xamarin.Forms;

namespace SampleRoundedButtonForms.CustomControls
{
    public class RoundedButton : Button
    {
        public RoundedButton()
        {

        }

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create<RoundedButton, double>(p => p.CornerRadius, 0);
        public double CornerRadius
        {
            get { return (double)base.GetValue(CornerRadiusProperty); }
            set { base.SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create<RoundedButton, int>(p => p.FontSize, 20);
        public int FontSize
        {
            get { return (int)base.GetValue(FontSizeProperty); }
            set { base.SetValue(FontSizeProperty, value); }
        }

        public static readonly BindableProperty StrokeProperty =
            BindableProperty.Create<RoundedButton, Color>(p => p.Stroke, Color.Transparent);
        public Color Stroke
        {
            get { return (Color)base.GetValue(StrokeProperty); }
            set { base.SetValue(StrokeProperty, value); }
        }

        public static readonly BindableProperty StrokeThicknessProperty =
            BindableProperty.Create<RoundedButton, double>(p => p.StrokeThickness, 0);
        public double StrokeThickness
        {
            get { return (double)base.GetValue(StrokeThicknessProperty); }
            set { base.SetValue(StrokeThicknessProperty, value); }
        }

        public static readonly BindableProperty ColorBackgroundProperty =
            BindableProperty.Create<RoundedButton, Color>(p => p.ColorBackground, Color.Blue);
        public Color ColorBackground
        {
            get { return (Color)base.GetValue(ColorBackgroundProperty); }
            set { base.SetValue(ColorBackgroundProperty, value); }
        }

        public static readonly BindableProperty ColorTextProperty =
            BindableProperty.Create<RoundedButton, Color>(p => p.ColorText, Color.White);
        public Color ColorText
        {
            get { return (Color)base.GetValue(ColorTextProperty); }
            set { base.SetValue(ColorTextProperty, value); }
        }
    }
}