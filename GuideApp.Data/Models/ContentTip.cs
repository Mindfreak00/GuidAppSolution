using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuideApp.Data.Models
{
    public class ContentTip
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string ContentImage { get; set; }
        public virtual Tip Tip { get; set; }
    }
}
