using ObserverDesignePattern.DAL;

namespace ObserverDesignePattern.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
