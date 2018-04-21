using GuideApp.Data.Models;
using GuideApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GuideApp.WebApi.Controllers
{
    public class TipsController : ApiController
    {
        private ITipService tipService;

        public TipsController(ITipService tipService)
        {
            this.tipService = tipService;
        }

        // GET api/values/5
        public Tip Get(Guid id)
        {
            return tipService.GetTip(id);
        }

        // GET api/values
        public IEnumerable<Tip> Get()
        {
            return tipService.GetTips();
        }

        // POST api/values
        public void Post([FromBody]Tip tip)
        {
            tipService.AddTip(tip);
            tipService.SaveTip();
        }

        // PUT api/values/5
        public void Put([FromBody]Tip tip)
        {
            tipService.UpdateTip(tip);
            tipService.SaveTip();
        }

        // DELETE api/values/5
        public void Delete(Tip tip)
        {
            tipService.DeleteTip(tip);
            tipService.SaveTip();
        }
    }
}
