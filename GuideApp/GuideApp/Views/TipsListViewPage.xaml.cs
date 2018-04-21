using GuideApp.Models;
using GuideApp.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipsListViewPage : ContentPage
    {
        public ObservableCollection<Tip> Items { get; set; }

        TipsService tipsService = new TipsService();
        public TipsListViewPage()
        {
            InitializeComponent();

            Items = tipsService.GetTips(new Uri("http://guideapp-api.el-hamdani.com/api/"));

            TipsListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
