using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = subAboutManager.TGetList();
            return await Task.FromResult((IViewComponentResult)View(values));
        }
    }
}
