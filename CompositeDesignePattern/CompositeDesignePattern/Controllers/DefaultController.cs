using CompositeDesignePattern.CompositePattern;
using CompositeDesignePattern.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompositeDesignePattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categorys.Include(x => x.Products).ToList();
            var values = Recursive(categories, new Category { CategoryName = "FirstCategory", CategoryID = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.Composite = values;

            return View();
        }

        public ProductComposite Recursive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leaf = null)
        {
            categories.Where(x => x.UpperCategoryID == firstCategory.CategoryID).ToList()
            .ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryID, y.CategoryName);

                y.Products.ToList().ForEach(p =>
                {
                    productComposite.AddComponent(new ProductComponent(p.ProductID, p.ProductName));
                });

                if (leaf != null)
                {
                    leaf.AddComponent(productComposite);
                }
                else
                {
                    firstComposite.AddComponent(productComposite);
                }
                Recursive(categories, y, firstComposite, productComposite);



            });
            return firstComposite;
        }



    } 
}
