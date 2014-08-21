using Android.Graphics;
using SampleRoundedButtonForms.CustomControls;
using SampleRoundedButtonForms.Droid.CustomControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedButton), typeof(RoundedButtonRenderer))]
namespace SampleRoundedButtonForms.Droid.CustomControls
{
    public class RoundedButtonRenderer : ButtonRenderer
    {
        public RoundedButtonRenderer()
        {
            this.SetWillNotDraw(false);
        }

        public override void Draw(global::Android.Graphics.Canvas canvas)
        {
            RoundedButton pb = (RoundedButton)this.Element;

            Rect rc = new Rect();
            GetDrawingRect(rc);

            Rect interior = rc;
            interior.Inset((int)pb.StrokeThickness, (int)pb.StrokeThickness);

            Paint p = new Paint()
            {
                AntiAlias = true,
            };

            p.Color = pb.ColorBackground.ToAndroid();

            canvas.DrawRoundRect(new RectF(interior), (float)pb.CornerRadius, (float)pb.CornerRadius, p);

            p.Color = pb.Stroke.ToAndroid();
            p.StrokeWidth = (float)pb.StrokeThickness;
            p.SetStyle(Paint.Style.Stroke);

            canvas.DrawRoundRect(new RectF(rc), (float)pb.CornerRadius, (float)pb.CornerRadius, p);

            p.Color = pb.ColorText.ToAndroid();
            p.TextSize = pb.FontSize;

            double xPos = (pb.Width / 2);
            double yPos = (pb.Height / 2);

            canvas.DrawText(pb.Text, (float)(xPos), (float)(yPos), p);
        }
    }
}