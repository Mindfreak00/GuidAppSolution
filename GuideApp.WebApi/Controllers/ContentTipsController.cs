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
    public class ContentTipsController : ApiController
    {
        private IContentTipService contentTipService;

        public ContentTipsController(IContentTipService contentTipService)
        {
            this.contentTipService = contentTipService;
        }

        // GET api/values/5
        public ContentTip Get(Guid id)
        {
            return contentTipService.GetContentTip(id);
        }

        // GET api/values
        public IEnumerable<ContentTip> Get()
        {
            return contentTipService.GetContentTips();
        }

        // POST api/values
        public void Post([FromBody]ContentTip contentTip)
        {
            contentTipService.AddContentTip(contentTip);
            contentTipService.SaveContentTip();
        }

        // PUT api/values/5
        public void Put([FromBody]ContentTip contentTip)
        {
            contentTipService.UpdateContentTip(contentTip);
            contentTipService.SaveContentTip();
        }

        // DELETE api/values/5
        public void Delete(ContentTip contentTip)
        {
            contentTipService.DeleteContentTip(contentTip);
            contentTipService.SaveContentTip();
        }
    }
}
