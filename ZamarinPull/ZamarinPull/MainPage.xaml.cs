using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZamarinPull
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DynamicLabel.Text = "test";
            var label = new Label
            {
                Text = "Dynamic lable added",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand
            };
            Layout1.Children.Add(label);
        }
    }
}
