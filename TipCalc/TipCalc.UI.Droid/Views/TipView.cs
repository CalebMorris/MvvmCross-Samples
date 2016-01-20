using Android.App;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Views;
using TipCalc.Core.ViewModels;

namespace TipCalc.UI.Droid.Views
{
    [Activity(Label = "Tip", MainLauncher = true)]
    public class TipView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.View_Tip);

			var set = this.CreateBindingSet<TipView, TipViewModel> ();

			var btnTest = this.FindViewById<Button> (Resource.Id.btnTest);

			set.Bind (btnTest).For("Click").To(vm => vm.ButtonPressed);

			set.Apply ();
        }
    }
}