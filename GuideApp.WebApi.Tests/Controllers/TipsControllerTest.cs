using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuideApp.WebApi.Controllers;
using GuideApp.Service;
using System.Collections.Generic;
using GuideApp.Data.Models;
using System.Linq;

namespace GuideApp.WebApi.Tests.Controllers
{
    [TestClass]
    public class TipsControllerTest
    {
        private ITipService tipService;

        [TestMethod]
        public void Get()
        {
            TipsController tipsController = new TipsController(tipService);

            IEnumerable<Tip> result = tipsController.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count());
            Assert.AreEqual(new Tip()
            {
                Id = new Guid("8fda5124-65b2-43e3-9414-34d18f62e17e"),
                Title = "title1",
                Content = "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                ImageUrl = "https://cdn.pocket-lint.com/r/s/1200x/assets/images/120309-phones-buyer-s-guide-best-smartphones-image1-cnxvifjlms.jpg"
            }, result.ElementAt(0));
        }
    }
}
