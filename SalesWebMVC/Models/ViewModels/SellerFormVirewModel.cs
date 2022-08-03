using System.Collections.Generic;

namespace SalesWebMVC.Models.ViewModels
{
    public class SellerFormVirewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
