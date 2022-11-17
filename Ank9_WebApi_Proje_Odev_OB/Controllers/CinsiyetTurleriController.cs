using Ank9_WebApi.Models;
using Ank9_WebApi_Proje_Odev_OB.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ank9_WebApi_Proje_Odev_OB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinsiyetTurleriController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<EnumItem>> GetEnumList()
        {
            List<EnumItem> list = new List<EnumItem>();
            string[] cinsiyet = Enum.GetNames<CinsiyetTipi>();
            CinsiyetTipi[] degerler = Enum.GetValues<CinsiyetTipi>();
            for (int i = 0; i < cinsiyet.Length; i++)
            {
                list.Add(new EnumItem()
                {
                    Name = cinsiyet[i],
                    Value = (int)degerler[i]
                });
            }
            return list;
        }
    }
}
