using OnlineStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.InterFaces
{
    public interface ProductInterFase
    {
        Task<Product> GetProduct();
        Task<List<Product>> GetProducts();
    }
}
