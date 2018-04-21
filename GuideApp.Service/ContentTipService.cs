using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideApp.Data.Models;
using GuideApp.Repository;
using GuideApp.Infrasructure;

namespace GuideApp.Service
{
    public class ContentTipService : IContentTipService
    {
        private readonly IContentTipRepository contentTipRepository;
        private readonly IUnitofWork unitOfWork;

        public ContentTipService(IContentTipRepository contentTipRepository, IUnitofWork unitOfWork)
        {
            this.contentTipRepository = contentTipRepository;
            this.unitOfWork = unitOfWork;
        }

        public void AddContentTip(ContentTip contentTip) => contentTipRepository.Add(contentTip);

        public void DeleteContentTip(ContentTip contentTip) => contentTipRepository.Delete(contentTip);

        public ContentTip GetContentTip(Guid id) => contentTipRepository.Get(id);

        public IEnumerable<ContentTip> GetContentTips() => contentTipRepository.GetAll();

        public void UpdateContentTip(ContentTip contentTip) => contentTipRepository.Update(contentTip);

        public void SaveContentTip() => unitOfWork.Commit();
    }
}
