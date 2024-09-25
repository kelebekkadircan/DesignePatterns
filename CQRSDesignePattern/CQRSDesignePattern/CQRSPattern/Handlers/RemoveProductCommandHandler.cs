using CQRSDesignePattern.CQRSPattern.Commands;
using CQRSDesignePattern.DAL;
using System;

namespace CQRSDesignePattern.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var product = _context.Products.Find(command.Id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        internal void Handle(int id)
        {
            throw new NotImplementedException();
        }
    }
}
