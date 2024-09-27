using ObserverDesignePattern.DAL;
using System;

namespace ObserverDesignePattern.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage {
                NameSurname = appUser.Name + " " + appUser.Surname,
                //City = appUser.City,
                //District = appUser.District,
                Content = "Dergi Bültenime Kayıt Olmuşsun Aferin , İyi Okumalar Dilerim."

            });
            context.SaveChanges();
            
        }
    }
}
