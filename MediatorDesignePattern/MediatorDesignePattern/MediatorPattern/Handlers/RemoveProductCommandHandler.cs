﻿using MediatorDesignePattern.DAL;
using MediatorDesignePattern.MediatorPattern.Commands;
using MediatR;

namespace MediatorDesignePattern.MediatorPattern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values =  _context.Products.Find(request.ID);
            _context.Products.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
