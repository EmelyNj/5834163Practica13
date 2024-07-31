using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace _5834163Practica13.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        #region SUMA
        [ObservableProperty]
        private double totalSum;

        [ObservableProperty]
        private double num1;

        [ObservableProperty]
        private double num2;

        [RelayCommand]
        public void Suma()
        {
            TotalSum = Num1 + Num2;
        }
        #endregion

        #region TRIANGULO
        [ObservableProperty]
        private double totalLado;

        [ObservableProperty]
        private double superficie;

        [ObservableProperty]
        private double multilados;

        [ObservableProperty]
        private double lado1;

        [ObservableProperty]
        private double lado2;

        [ObservableProperty]
        private double lado3;

        [RelayCommand]
        public void area()
        {
            Superficie = (Lado1 + Lado2 + Lado3) / 2;

            Multilados = Superficie * (Superficie - Lado1) * (Superficie - Lado2) * (Superficie - Lado3);

            TotalLado = Math.Sqrt(Multilados);
        }

        #endregion

        #region DISTANCIA
        [ObservableProperty]
        private double totalDis;

        [ObservableProperty]
        private double xtot;
        [ObservableProperty]
        private double ytot;
        [ObservableProperty]
        private double sumadis;

        [ObservableProperty]
        private double x1;
        [ObservableProperty]
        private double x2;
        [ObservableProperty]
        private double y1;
        [ObservableProperty]
        private double y2;

        [ObservableProperty]
        private double eleX;
        [ObservableProperty]
        private double eleY;



        [RelayCommand]
        public void Distancia()
        {
            Xtot = X1 - X2;
            EleX = Math.Pow(Xtot, 2);

            Ytot = Y1 - Y2;
            EleY = Math.Pow(Ytot, 2);

            Sumadis = EleX + EleY;

            TotalDis = Math.Sqrt(Sumadis);
        }

        #endregion

        #region BROCHA

        [ObservableProperty]
        private double totPresupuesto;

        [ObservableProperty]
        private double metros;

        [ObservableProperty]
        private double precio;

        [RelayCommand]
        public void TotalPresupuesto()
        {
            TotPresupuesto = Precio * Metros;
        }

        #endregion

        #region SUELDO
        [ObservableProperty]
        private double totalSueldo;

        [ObservableProperty]
        private double sT;

        [RelayCommand]
        public void SueldoAumentado() {

            if (ST >= 1000)
            {
                TotalSueldo = ST * 1.15;
            }
            else
            {
                TotalSueldo = ST * 1.12;
            }
        }

        #endregion
    }
}
