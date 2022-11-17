using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ank9_WebApi.Models.Data;
using Ank9_WebApi.Models;
using System.Reflection.Metadata.Ecma335;

namespace Ank9_WebApi_Proje_Odev_OB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        private readonly Ank9_WebApiDbContext _db;

        public ServerController(Ank9_WebApiDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<ICollection<Kisiler>> Get()
        {
            return _db.Kisiler == null ? BadRequest() : _db.Kisiler.OrderBy(x => x.Ad).ToList();
        }

        [HttpGet("ben/{tc:int}")]
        public ActionResult<Kisiler> GetKisilerByTCKimlik(int tc)
        {
            return tc.ToString().Length != 5 ? BadRequest() :
                _db.Kisiler.Where(x => x.TCKimlik == tc).Count() != 1 ?
                NotFound() : _db.Kisiler.Where(x => x.TCKimlik == tc).FirstOrDefault();
        }

        [HttpGet("{dogumgunu:int}")]
        public ActionResult<ICollection<Kisiler>> GetKisilerByDogumGunu(int dogumgunu)
        {
            return dogumgunu < 1 && dogumgunu > 12 ? BadRequest() :
                _db.Kisiler.Where(x => x.DogumTarihi.Month == dogumgunu).Count() < 1 ? NotFound() :
                _db.Kisiler.Where(x => x.DogumTarihi.Month == dogumgunu).OrderByDescending(x => x.DogumTarihi).ToList();
        }

        [HttpPost("ekle")]
        public ActionResult<Kisiler> KisiEkle(Kisiler kisi)
        {
            try
            {
                Kisiler yeniKisi = new Kisiler { Ad = kisi.Ad, Soyad = kisi.Soyad, TCKimlik = kisi.TCKimlik, DogumTarihi = kisi.DogumTarihi, Cinsiyet = kisi.Cinsiyet };

                _db.Kisiler.Add(yeniKisi);
                _db.SaveChanges();
                return yeniKisi;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("degistir/{id:int}")]
        public ActionResult<Kisiler> GuncellenenKisi(int id, Kisiler guncellenenKisi)
        {
            if (id < 1)
            {
                return BadRequest();
            }
            else if (id != guncellenenKisi.KisiId)
            {
                return BadRequest();
            }
            Kisiler secilenKisi = _db.Kisiler.Find(id);
            secilenKisi.Ad = guncellenenKisi.Ad;
            secilenKisi.Soyad = guncellenenKisi.Soyad;
            secilenKisi.TCKimlik = guncellenenKisi.TCKimlik;
            secilenKisi.DogumTarihi = guncellenenKisi.DogumTarihi;
            secilenKisi.Cinsiyet = guncellenenKisi.Cinsiyet;
            _db.Kisiler.Update(secilenKisi);
            _db.SaveChanges();
            return secilenKisi;            
        }

        [HttpDelete("sil/{ad}/{soyad}")]
        public void KisiSil(string ad, string soyad)
        {
            var secilenKisi = _db.Kisiler.Where(x => x.Ad == ad && x.Soyad == soyad).FirstOrDefault();
            _db.Kisiler.Remove(secilenKisi);
            _db.SaveChanges();
        }
    }
}
