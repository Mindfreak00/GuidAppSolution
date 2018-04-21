using GuideApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuideApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipsListGridPage : ContentPage
    {
        int count = 0;
        int positionLeft = 0;
        int positionTop = 0;
        TipsService tipsService = new TipsService();
        public TipsListGridPage()
        {
            var tips = tipsService.GetTips(new Uri("http://guideapp-api.el-hamdani.com/api/"));
            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = 20
            };

            var grid = new Grid
            {
                RowSpacing = 50
            };

            foreach (var c in tips)
            {
                grid.Children.Add(new Label { Text = c.Title }, 0, positionTop++); // Left, First element
                //if (++count % 2 == 0)
                //{
                //    positionTop++;
                //}

            }
            //    grid.Children.Add(new Label { Text = "This" }, 0, 0); // Left, First element
            //grid.Children.Add(new Label { Text = "text is" }, 1, 0); // Right, First element
            //grid.Children.Add(new Label { Text = "in a" }, 0, 1); // Left, Second element
            //grid.Children.Add(new Label { Text = "grid!" }, 1, 1); // Right, Second element

            //var gridButton = new Button { Text = "So is this Button!\nClick me." };
            //gridButton.Clicked += delegate
            //{
            //    gridButton.Text = string.Format("Thanks! {0} clicks.", count++);
            //};

            layout.Children.Add(grid);
            //layout.Children.Add(gridButton);
            Content = layout;
            InitializeComponent();
        }
    }
}