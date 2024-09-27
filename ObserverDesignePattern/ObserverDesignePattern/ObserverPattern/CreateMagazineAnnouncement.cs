using ObserverDesignePattern.DAL;
using System;

namespace ObserverDesignePattern.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                //City = appUser.City,
                //District = appUser.District,
                Content = "Dergi DUYURUMA Kayıt Olmuşsun Aferin , İyi Okumalar Dilerim.",
                Magazine = "Dergi Duyurumu Magazinine Kayıt Oldun aFERİN"

            });
            context.SaveChanges();
        }
    }
}
