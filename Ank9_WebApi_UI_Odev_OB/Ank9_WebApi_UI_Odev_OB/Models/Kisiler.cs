namespace Ank9_WebApi_UI_Odev_OB.Models
{
    public enum CinsiyetTipi { E, K }
    public class Kisiler
    {
        public int KisiId { get; set; }

        public int TCKimlik { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public CinsiyetTipi Cinsiyet { get; set; }
    }
}