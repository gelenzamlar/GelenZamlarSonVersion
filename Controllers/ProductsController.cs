using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using V2GELENZAMLARV2.Data;

namespace V2GELENZAMLARV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Response response = new Response();
        private readonly DataContext _context;
        List<Products> _products = new List<Products>();


        public ProductsController(DataContext context)
        {
            _context = context;
        }




    





   [HttpGet]
        public Object Get()
        {
          
             Object temp =(from all in _context.Urunlerim.OrderBy(x => x.UrunID) select all).ToList();
                  
            return temp;
        }
    }
}

 