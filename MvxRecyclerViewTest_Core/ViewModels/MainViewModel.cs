using MvvmCross.Core.ViewModels;

namespace MvxRecyclerViewTest_Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public void ShowInitialViewModel()
        {
            ShowViewModel<FirstViewModel>();
        }
    }
}
