using GuideApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideApp.Services
{
    public interface ITipsService
    {
        Tip GetTip(Guid id, Uri uri);
        ObservableCollection<Tip> GetTips(Uri uri);
    }
}
