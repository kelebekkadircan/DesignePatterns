using CQRSDesignePattern.CQRSPattern.Commands;
using CQRSDesignePattern.CQRSPattern.Handlers;
using CQRSDesignePattern.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CQRSDesignePattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIDQueryHandler _getProductUpdateByIDQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

      
        public DefaultController(GetProductQueryHandler getProductQueryHandler , CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            this._getProductQueryHandler = getProductQueryHandler;
            this._createProductCommandHandler = createProductCommandHandler;
            this._getProductByIdQueryHandler = getProductByIdQueryHandler;
            this._removeProductCommandHandler = removeProductCommandHandler;
            this._getProductUpdateByIDQueryHandler = getProductUpdateByIDQueryHandler;
            this._updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public  IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult AddProduct(CreateProductCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command), "Command cannot be null");
            }



            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult GetProduct(int id)
        {
            var values = _getProductByIdQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(values);
        }

        public IActionResult DeleteProduct(int id) {
            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateByIDQueryHandler.Handle(new GetProductUpdateByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command), "Command cannot be null");
            }

            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

    }
}
