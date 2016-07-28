using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvxRecyclerViewTest_Core;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Platform;

namespace MvxRecyclerViewTest
{
    public class Setup : MvxAppCompatSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {

        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var mvxFragmentPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentPresenter);
            return mvxFragmentPresenter;
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }
    }
}