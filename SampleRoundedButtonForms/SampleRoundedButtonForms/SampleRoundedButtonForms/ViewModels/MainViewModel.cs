using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleRoundedButtonForms.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel() { }

        private string btnSimpleText = "Simple";
        public const string BtnSimpleTextPropertyName = "BtnSimpleText";
        public string BtnSimpleText
        {
            get { return btnSimpleText; }
            set { SetProperty(ref btnSimpleText, value, BtnSimpleTextPropertyName); }
        }

        private Xamarin.Forms.Color btnSimpleBackgroundColor = Xamarin.Forms.Color.FromHex("ffffff");
        public const string BtnSimpleBackgroundColorPropertyName = "BtnSimpleBackgroundColor";
        public Xamarin.Forms.Color BtnSimpleBackgroundColor
        {
            get { return btnSimpleBackgroundColor; }
            set { SetProperty(ref btnSimpleBackgroundColor, value, BtnSimpleBackgroundColorPropertyName); }
        }

        private Xamarin.Forms.Color btnSimpleTextColor = Xamarin.Forms.Color.FromHex("000000");
        public const string BtnSimpleTextColorPropertyName = "BtnSimpleTextColor";
        public Xamarin.Forms.Color BtnSimpleTextColor
        {
            get { return btnSimpleTextColor; }
            set { SetProperty(ref btnSimpleTextColor, value, BtnSimpleTextColorPropertyName); }
        }

        private string btnRoundedText = "Rounded";
        public const string BtnRoundedTextPropertyName = "BtnRoundedText";
        public string BtnRoundedText
        {
            get { return btnRoundedText; }
            set { SetProperty(ref btnRoundedText, value, BtnRoundedTextPropertyName); }
        }

        private Xamarin.Forms.Color btnRoundedBackgroundColor = Xamarin.Forms.Color.FromHex("ffffff");
        public const string BtnRoundedBackgroundColorPropertyName = "BtnRoundedBackgroundColor";
        public Xamarin.Forms.Color BtnRoundedBackgroundColor
        {
            get { return btnRoundedBackgroundColor; }
            set { SetProperty(ref btnRoundedBackgroundColor, value, BtnRoundedBackgroundColorPropertyName); }
        }

        private Xamarin.Forms.Color btnRoundedTextColor = Xamarin.Forms.Color.FromHex("000000");
        public const string BtnRoundedTextColorPropertyName = "BtnRoundedTextColor";
        public Xamarin.Forms.Color BtnRoundedTextColor
        {
            get { return btnRoundedTextColor; }
            set { SetProperty(ref btnRoundedTextColor, value, BtnRoundedTextColorPropertyName); }
        }

        #region Commands
        private Command roundedCommand;
        public Command RoundedCommand
        {
            get { return roundedCommand ?? (roundedCommand = new Command(() => ExecuteRoundedCommand())); }
        }

        private Command simpleCommand;
        public Command SimpleCommand
        {
            get { return simpleCommand ?? (simpleCommand = new Command(() => ExecuteSimpleCommand())); }
        }
        #endregion

        #region Private Methods
        private void ExecuteRoundedCommand()
        {
            BtnRoundedText = "Click";
            BtnRoundedBackgroundColor = Xamarin.Forms.Color.FromHex("ff1a00");
            BtnRoundedTextColor = Xamarin.Forms.Color.FromHex("00ff38");
        }
        private void ExecuteSimpleCommand()
        {
            BtnSimpleText = "Click";
            BtnSimpleBackgroundColor = Xamarin.Forms.Color.FromHex("ff1a00");
            BtnSimpleTextColor = Xamarin.Forms.Color.FromHex("00ff38");
        }
        #endregion
    }
}