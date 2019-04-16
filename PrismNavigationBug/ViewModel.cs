using Prism.Navigation;

namespace PrismNavigationBug
{
    public class ViewModel : /*INavigatedAware,*/ IDestructible
    {
        /*
        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }
        */
        public void Destroy()
        {
            
        }
    }
}