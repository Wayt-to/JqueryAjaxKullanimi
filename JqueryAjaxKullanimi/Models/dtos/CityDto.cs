namespace JqueryAjaxKullanimi.Models.dtos
{
    public class CityDto
    {
        //cdto yerine kullanılabilecek bir data transfer object () sınıf oluşturuyoruz, var şeklinde kullanılmazsa bu dto kulanılır çünkü ajax virtual tablolu sınıflarsda sorn yaratıyor.
        public int ID;
        public string Name;
    }
}