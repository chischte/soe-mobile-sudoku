using System.ComponentModel;
using Xamarin.Forms;

namespace Calculator
{

    public enum FieldColor
    {
        Black = 0, // Neutral Color
        Red = 1,   // Wrong Fields
        Green = 2, // Correct Fields
    }


    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;

        }
    }
}
