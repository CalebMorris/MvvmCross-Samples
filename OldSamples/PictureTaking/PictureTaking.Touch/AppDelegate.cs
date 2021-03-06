using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;

namespace PictureTaking.Touch
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate
    {
        private UIWindow _window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            _window = new UIWindow(UIScreen.MainScreen.Bounds);

            var presenter = new MvxTouchViewPresenter(this, _window);
            var setup = new Setup(this, presenter);
            setup.Initialize();

            var startup = Mvx.Resolve<IMvxAppStart>();
            startup.Start();

            _window.MakeKeyAndVisible();

            return true;
        }
    }
}