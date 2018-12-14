using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;


namespace ZamarinPull
{
    public partial class MainPage : ContentPage
    {
        private int val;
        public MainPage()
        {
            InitializeComponent();
            DynamicLabel.Text = "test";
         
            var uri = new Uri("http://10.0.0.51:48321/Home/Index/0");
            try
            {
                HttpClient client;
                client = new HttpClient();
                client.MaxResponseContentBufferSize = 256000;
                var response = client.GetAsync(uri).Result;
                var content = response.Content.ReadAsStringAsync().Result;
                val = JsonConvert.DeserializeObject<int>(content);
                var label = new Label
                {
                    Text = val.ToString(),
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.StartAndExpand,

                };

                Layout1.Children.Add(label);
            }
            catch (Exception ex)
            {
                var label = new Label
                {
                    Text = ex.Message,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.StartAndExpand,

                };
                Layout1.Children.Add(label);
            }
            Refresh.Clicked += Refresh_Clicked;
          
        }

        private void Refresh_Clicked(object sender, EventArgs e)
        {
            var uri = new Uri("http://10.0.0.51:48321/Home/Index/"+val.ToString());
            try
            {
                HttpClient client;
                client = new HttpClient();
                client.MaxResponseContentBufferSize = 256000;
                var response = client.GetAsync(uri).Result;
                var content = response.Content.ReadAsStringAsync().Result;
                val = JsonConvert.DeserializeObject<int>(content);
                var label = new Label
                {
                    Text = val.ToString(),
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.StartAndExpand,

                };

                Layout1.Children.Add(label);
            }
            catch (Exception ex)
            {
                var label = new Label
                {
                    Text = ex.Message,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.StartAndExpand,

                };
                Layout1.Children.Add(label);
            }
        }
    }
}
