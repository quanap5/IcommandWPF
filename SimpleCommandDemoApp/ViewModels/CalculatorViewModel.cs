using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SimpleCommandDemoApp.Commands.Specific;
using SimpleCommandDemoApp.Commands.Generic;

namespace SimpleCommandDemoApp.ViewModels
{
    public class CalculatorViewModel: ViewModelBase
    {
        #region private
        private double firstValue;
        private double secondValue ;
        private double output; 

        private PlusCommand plusCommand;
        private MinusCommand minusCommand;
        private DivionCommand divisionCommand;
        private MultiplyCommand multiplyCommand;


        public CalculatorViewModel()
        {
            plusCommand = new PlusCommand(this);
            minusCommand = new MinusCommand(this);
            multiplyCommand = new MultiplyCommand(this);
            divisionCommand = new DivionCommand(this);
        }


        #endregion


        #region properties
        public double FirstValue
        {
            get { return firstValue; }

            set
            {
                firstValue = value;
                OnPropertyChanged("FirstValue");
            }
        }

        public double SecondValue
        {
            get { return secondValue; }

            set
            {
                secondValue = value;
                OnPropertyChanged("SecondValue");
            }
        }

        public double Output
        {
            get { return output; }

            set
            {
                output = value;
                OnPropertyChanged("Output");
            }
        }
        #endregion



        #region Command

        public ICommand AddCommand
        {
            get
            {
                //return plusCommand;
                return new RelayCommand(Add);
            }
        }

        public ICommand MinusCommand
        {
            get
            {
                //return minusCommand;
                return new RelayCommand(Minus);
            }
        }

        public ICommand MulCommand
        {
            get
            {
                // return multiplyCommand;

                return new RelayCommand(Multiply);
            }
        }

        public ICommand DivideCommand
        {
            get
            {
                //return divisionCommand;
                return new RelayCommand(Divide);
            }
        }
        #endregion




        #region method
        public void Add()
        {
            Output = firstValue + secondValue;
            Debug.WriteLine(output);
        }

        public void Minus()
        {
            Output = firstValue - secondValue;
            Debug.WriteLine(output);
        }

        public void Multiply()
        {
            Output = firstValue * secondValue;
            Debug.WriteLine(output);
        }

        public void Divide()
        {
            Output = firstValue/secondValue;
            Debug.WriteLine(output);
        }
        #endregion


    }
}