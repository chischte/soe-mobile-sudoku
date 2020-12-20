using System.ComponentModel;
using SudokuApp.ViewModel;
using Xamarin.Forms;

namespace SudokuApp.view
{
    

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
