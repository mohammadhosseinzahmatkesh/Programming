using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
   
    public partial class MainWindow : Window
    {
        SimpleMath SimpleMath = new SimpleMath();
         //
        SelectOperator selectOperator;
        //
        
        double LastNumber, NewNumber, Result;
        string Shape = "";
        int SelectValue;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            ResultLable.Content = "0.";
            BackLable.Content = "0";
            Result = 0;
            LastNumber = 0;
        }


        private void NegativButton_Click(object sender, RoutedEventArgs e)
        {

            if(double.TryParse(ResultLable.Content.ToString(), out LastNumber)) 
            {
                LastNumber = LastNumber * -1;
                ResultLable.Content = LastNumber.ToString();
            }
        }


        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            double TempNumber;
            if (double.TryParse(ResultLable.Content.ToString(), out TempNumber))
            {
                TempNumber = TempNumber / 100;
                if (LastNumber != 0)
                    TempNumber *= LastNumber;
                ResultLable.Content = TempNumber.ToString();
            }
        }


        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if (ResultLable.Content.ToString().Contains("."))
            {
              //Do Nothing
            }

            else
            {
                ResultLable.Content = $"{ResultLable.Content}.";
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == PlusButton)
                Shape = "+";
            if (sender == MinusButton)
                Shape = "-";
            if (sender == MultiplyButton)
                Shape = "*";
            if (sender == DivisionButton)
                Shape = "/";



            if (double.TryParse(ResultLable.Content.ToString(), out LastNumber))
            {
                ResultLable.Content = "0";
                BackLable.Content = $"{LastNumber}{Shape}";
            }

            if (sender == PlusButton)
            {
                selectOperator = SelectOperator.Addition;
            }

            if (sender == MinusButton)
            {
                selectOperator = SelectOperator.Sustraction;
            }

            if (sender == MultiplyButton)
            {
                selectOperator = SelectOperator.Multiplicatin;
            }

            if (sender == DivisionButton)
            {
                selectOperator = SelectOperator.Division;
            }
        }


        private void NumberButtom_Click(object sender, RoutedEventArgs e)
        {
            SelectValue = int.Parse((sender as Button).Content.ToString());


            if (ResultLable.Content.ToString() == "0.")
            {
                ResultLable.Content = SelectValue;
                BackLable.Content = $"{SelectValue}";
            }

            else if (ResultLable.Content.ToString() == "0")
            {
                ResultLable.Content = SelectValue;
                BackLable.Content = $"{LastNumber}{Shape}{SelectValue}";
            }

            else
            {
                ResultLable.Content = $"{ResultLable.Content}{SelectValue}";
                BackLable.Content = $"{BackLable.Content}{SelectValue}";
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (LastNumber == 0 )
            {
                ResultLable.Content = ResultLable.Content;
                BackLable.Content = BackLable.Content;
            }

            else if (double.TryParse(ResultLable.Content.ToString(), out NewNumber))
            {
                switch(selectOperator)
                {
                    case SelectOperator.Addition:
                        Result = SimpleMath.Add(LastNumber, NewNumber);
                        break;

                    case SelectOperator.Sustraction:
                        Result = SimpleMath.Sustraction(LastNumber, NewNumber);
                        break;

                    case SelectOperator.Multiplicatin:
                        Result = SimpleMath.Multiply(LastNumber, NewNumber);
                        break;

                    case SelectOperator.Division:
                        Result = SimpleMath.Divide(LastNumber, NewNumber);
                        break;
                }

                ResultLable.Content = Result.ToString();
                BackLable.Content = $"{LastNumber}{Shape}{SelectValue} = {Result.ToString()}";
            }
        }
    }


    public enum SelectOperator
    {
        Addition,
        Sustraction,
        Multiplicatin,
        Division
    }
}
