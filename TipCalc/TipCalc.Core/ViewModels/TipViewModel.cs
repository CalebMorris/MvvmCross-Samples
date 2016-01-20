

using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        readonly ICalculation _calculation;

        public TipViewModel(ICalculation calculation)
        {
            _calculation = calculation;

            ShowViewModel<TestViewModel>();
        }

        public override void Start()
        {
            _subTotal = 100;
            _generosity = 10;
            Recalcuate();
            base.Start();
        }

        double _subTotal;

        public double SubTotal
        {
            get { return _subTotal; }
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalcuate();
            }
        }

        int _generosity;

        public int Generosity
        {
            get { return _generosity; }
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalcuate();
            }
        }

        double _tip;

        public double Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        void Recalcuate()
        {
            Tip = _calculation.TipAmount(SubTotal, Generosity);
        }

        IMvxCommand _buttonPressed;
        public IMvxCommand ButtonPressed {
            get { return _buttonPressed ?? (_buttonPressed = new MvxCommand(ExecuteButtonPressed)); }
        }

        public void ExecuteButtonPressed()
        {
            ShowViewModel<TestViewModel>();
        }
    }
}
