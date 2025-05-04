using System.Collections.Generic;

namespace JqueryAjaxKullanimi.Models
{
    //[Serializable]
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<County> Counties { get; set; }
    }
}