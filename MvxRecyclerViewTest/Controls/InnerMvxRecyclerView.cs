using Android.Content;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using MvvmCross.Droid.Support.V7.RecyclerView;
using System;

namespace MvxRecyclerViewTest.Controls
{
    [Register("mvxrecyclerviewtest.controls.InnerMvxRecyclerView")]
    public class InnerMvxRecyclerView : MvxRecyclerView
    {
        public InnerMvxRecyclerView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }

        public InnerMvxRecyclerView(Context context, IAttributeSet attrs) : base(context, attrs)
        {

        }

        public InnerMvxRecyclerView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {

        }

        public InnerMvxRecyclerView(Context context, IAttributeSet attrs, int defStyle, IMvxRecyclerAdapter adapter) : base(context, attrs, defStyle, adapter)
        {

        }

        private void Init(Context context)
        {
            SetLayoutManager(new UnScrollableLinearLayoutManager(context, LinearLayoutManager.Vertical, false));

            SetItemAnimator(new DefaultItemAnimator());
            NestedScrollingEnabled = false;
        }

        protected override void OnDetachedFromWindow()
        {
            //Do Nothing - Prevents Binding Context from being cleared
        }
    }
}