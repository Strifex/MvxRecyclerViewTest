using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvxRecyclerViewTest_Core.ViewModels;

namespace MvxRecyclerViewTest
{
    [Activity(Label = "MvxRecyclerViewTest", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            ViewModel.ShowInitialViewModel();
        }
    }
}

