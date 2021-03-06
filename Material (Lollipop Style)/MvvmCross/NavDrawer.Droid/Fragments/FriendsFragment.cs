using NavDrawer.Droid;
using Android.Support.V4.View;
using com.refractored;
using Android.Support.V4.App;
using Android.OS;
using NavDrawer.Adapters;
using Android.Runtime;
using Cirrious.MvvmCross.Droid.FullFragging.Fragments;
using NavDrawer.Core.ViewModels;


namespace NavDrawer.Fragments
{
    [Register("navdrawer.fragments.FriendsFragment")]
    public class FriendsFragment : MvxFragment<FriendsViewModel>
    {
        private ViewPager m_ViewPager;
        private PagerSlidingTabStrip m_PageIndicator;
        private FragmentPagerAdapter m_Adapter;

        public FriendsFragment()
        {
            this.RetainInstance = true;
        }

        public override Android.Views.View OnCreateView(Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(NavDrawer.Droid.Resource.Layout.fragment_friends, null);

            // Create your application here
            this.m_ViewPager = view.FindViewById<ViewPager>(NavDrawer.Droid.Resource.Id.viewPager);
            this.m_ViewPager.OffscreenPageLimit = 4;
						this.m_PageIndicator = view.FindViewById<PagerSlidingTabStrip>(NavDrawer.Droid.Resource.Id.tabs);

            //Since we are a fragment in a fragment you need to pass down the child fragment manager!
            //this.m_Adapter = new FriendsAdapter(this.ChildFragmentManager);


            //this.m_ViewPager.Adapter = this.m_Adapter;

            this.m_PageIndicator.SetViewPager(this.m_ViewPager);
            return view;
        }

    }
}