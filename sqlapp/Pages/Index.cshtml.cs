using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlapp.Models;
using sqlapp.Services;

namespace sqlapp.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IProductService productService)
        {
            this.productService = productService;
        }
        public List<Product> Products;
        private readonly IProductService productService;

        public void OnGet()
        { 
            Products= productService.GetProducts();

        }
    }
}