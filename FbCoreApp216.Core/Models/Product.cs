using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Core.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        //ForeignKey olacak CategoryID
        public int CategoryID { get; set; }
        public bool IsDeleted { get; set; }
        public string InnerBarcode { get; set; }


        public Category Category { get; set; }
    }
}
