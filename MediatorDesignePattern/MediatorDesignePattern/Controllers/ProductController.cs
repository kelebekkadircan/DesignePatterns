using MediatorDesignePattern.MediatorPattern.Commands;
using MediatorDesignePattern.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorDesignePattern.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }


       
        public async Task<IActionResult> Index()
        {
            // Asenkron işlemi bekleyin
            var values = await _mediator.Send(new GetAllProductQuery());

            // Modeli view'e gönderin
            return View(values);
        }

        public async Task<IActionResult> GetProduct(int id)
        {
            var values = await _mediator.Send(new GetProductByIDQuery(id));
            return View(values);
        }

        public async Task<IActionResult> RemoveProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var values = await _mediator.Send(new GetProductUpdateByIDQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }


     }
}
