using System;
using Android.Content;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;

namespace MvxRecyclerViewTest.Controls
{
    public class UnScrollableLinearLayoutManager : LinearLayoutManager
    {
        public UnScrollableLinearLayoutManager(Context context) : base(context)
        {

        }

        public UnScrollableLinearLayoutManager(Context context, int orientation, bool reverseLayout) : base(context, orientation, reverseLayout)
        {

        }

        public UnScrollableLinearLayoutManager(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {

        }

        public UnScrollableLinearLayoutManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }

        public override bool CanScrollVertically()
        {
            return false;
        }
    }
}