using GuideApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideApp.Service
{
    public interface ITipService
    {
        Tip GetTip(Guid id);
        void AddTip(Tip tip);
        void UpdateTip(Tip tip);
        void DeleteTip(Tip tip);
        IEnumerable<Tip> GetTips();
        void SaveTip();
    }
}
