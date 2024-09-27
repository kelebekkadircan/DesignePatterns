using ObserverDesignePattern.DAL;
using System;

namespace ObserverDesignePattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
           context.Discounts.Add(new Discount
            {
                DiscountCodeStatus = true,
                DiscountAmount = 120,
                DiscountCode = "GURAY10"

            });
            context.SaveChanges();
        }
    }
}

