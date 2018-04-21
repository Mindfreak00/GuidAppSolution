using GuideApp.Models;
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
    public partial class TipsListPage : CarouselPage
    {
        TipsService tipsService = new TipsService();
        public TipsListPage()
        {
            List<ContentPage> pages = new List<ContentPage>(0);

            Color[] colors = { Color.Red, Color.Green, Color.Bisque };
            var tips = tipsService.GetTips(new Uri("http://guideapp-api.el-hamdani.com/api/"));
            foreach (var c in tips)
            {
                //pages.Add(new ContentPage
                //{
                //    Content = new StackLayout
                //    {
                //        Children = {
                //            new Label { Text = c.Title },
                //            new Image { Source = c.ImageUrl },
                //            new Label { Text = c.Content}
                //        }
                //    }
                //});

                Children.Add(new ContentPage
                {
                    Content = new StackLayout
                    {
                        Children = {
                            new Label { Text = c.Title },
                            new Image { Source = ImageSource.FromUri(new Uri(c.ImageUrl)) },
                            new Label { Text = c.Content}
                        }
                    }
                });
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    Children.Add(pages[i]);
            //}

            InitializeComponent();
        }
    }
}