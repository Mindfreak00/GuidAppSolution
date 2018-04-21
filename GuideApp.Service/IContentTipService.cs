using GuideApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideApp.Service
{
    public interface IContentTipService
    {
        ContentTip GetContentTip(Guid id);
        void AddContentTip(ContentTip contentTip);
        void UpdateContentTip(ContentTip contentTip);
        void DeleteContentTip(ContentTip contentTip);
        IEnumerable<ContentTip> GetContentTips();
        void SaveContentTip();
    }
}
