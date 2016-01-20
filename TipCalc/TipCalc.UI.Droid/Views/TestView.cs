using Android.App;
using MvvmCross.Droid.Views;

namespace TipCalc.UI.Droid.Views
{
	[Activity(Label = "Test")]
	public class TestView : MvxActivity
	{
		protected override void OnViewModelSet()
		{
			SetContentView(Resource.Layout.Test);
		}
	}
}