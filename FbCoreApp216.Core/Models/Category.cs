using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Core.Models
{
    public class Category:BaseEntity
    {
        public Category()
        {
            //Products=new Collection<Product>();
        }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }


        public virtual ICollection<Product> Products { get; set; } = new Collection<Product>();
        /*neden virtual kullandık?
          
        * Eager Loading :Bütün tabloyu yüklemeyi sağlar (Bağlı tablolar dahil)
        * Oluşturulan nesnenin bağlı tabloların bilgilerini de içerir.
        * 
        * 
        * 
        * Lazy Loading :Bağlı tabloların içeriğini vermez.
        * Olusturan nesnenin baglı olduğu bilgileri getirmez sadece navigation columnu getirir.
        * virtual demezsek product tablosunda kategori içindeki tüm sütunları ekler.Virtual dersek sadece kategoriID ekler.
        * 
        */
    }
}
