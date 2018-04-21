using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuideApp.Data.Models;
using GuideApp.Infrasructure;
using GuideApp.Repository;

namespace GuideApp.Service
{
    public class TipService : ITipService
    {
        private readonly ITipRepository tipRepository;
        private readonly IUnitofWork unitOfWork;

        public TipService(ITipRepository tipRepository, IUnitofWork unitOfWork)
        {
            this.tipRepository = tipRepository;
            this.unitOfWork = unitOfWork;
        }

        public void AddTip(Tip tip) => tipRepository.Add(tip);

        public void DeleteTip(Tip tip) => tipRepository.Delete(tip);

        public Tip GetTip(Guid id) => tipRepository.Get(id);

        public IEnumerable<Tip> GetTips() => tipRepository.GetAll();

        public void UpdateTip(Tip tip) => tipRepository.Update(tip);

        public void SaveTip() => unitOfWork.Commit();
    }
}
