using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Semana11A2023.ViewModels
{
    public class ViewModelOperaciones : ViewModelBase 
    {

        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }


        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }



        int resultado;
        public int Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        


        public ICommand Sumar { protected set; get; }
        public ICommand Division { protected set; get; }
        public ICommand Restar { protected set; get; }

        public ICommand Multiplicar { protected set; get; }


        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                Resultado = ValorA + ValorB;
            });

            Division= new Command(() =>
            {
                Resultado = ValorA / ValorB;
            });

            Restar = new Command(() =>
            {
                Resultado = ValorA - ValorB;
            });

            Multiplicar = new Command(() =>
            {
                Resultado = ValorA * ValorB;
            });
        }

    }
}
