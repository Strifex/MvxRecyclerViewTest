using MvvmCross.Core.ViewModels;
using MvxRecyclerViewTest_Core.ViewModels;

namespace MvxRecyclerViewTest_Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}
