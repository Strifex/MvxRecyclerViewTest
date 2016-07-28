using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvxRecyclerViewTest_Core.ViewModels;

namespace MvxRecyclerViewTest.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("mvxrecyclerviewtest.fragments.FirstFragment")]
    public class FirstFragment : BaseFragment<FirstViewModel>
    {
        protected override int FragmentId => Resource.Layout.reyclerViewExample;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            var reyclerView = view.FindViewById<MvxRecyclerView>(Resource.Id.recycler_view);
            if (reyclerView != null)
            {
                var layoutManager = new LinearLayoutManager(Activity);
                reyclerView.SetLayoutManager(layoutManager);
            }

            return view;
        }
    }
}