using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideApp.Models;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace GuideApp.Services
{
    public class TipsService : ITipsService
    {
        public TipsService() { }
        public Tip GetTip(Guid id, Uri uri)
        {
            Tip tip = null;
            HttpClient client = new HttpClient() { BaseAddress = uri };
            HttpResponseMessage response = client.GetAsync("tips/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                tip = response.Content.ReadAsAsync<Tip>().Result;
            }
            return tip;
        }

        public ObservableCollection<Tip> GetTips(Uri uri)
        {
            ObservableCollection<Tip> tips = null;
            HttpClient client = new HttpClient() { BaseAddress = uri };
            HttpResponseMessage response = client.GetAsync("tips/").Result;
            if (response.IsSuccessStatusCode)
            {
                tips = response.Content.ReadAsAsync<ObservableCollection<Tip>>().Result;
            }
            return tips;
        }

    }
}
