using CommunityToolkit.Mvvm.ComponentModel;
using System;
namespace Examen_Mvvm.ViewModels
{
    internal class Examen_MvvmViewModels : ObservableObject
    {
        [ObservableProperty]
        private double producto1;

        [ObservableProperty]
        private double producto2;

        [ObservableProperty]
        private double producto3;

        [ObservableProperty]
        private double subTotal;

        [ObservableProperty]
        private double descuento;

        [ObservableProperty]
        private double totalPagar;
        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            double totalSumaProductos = producto1 + producto2 + producto3;

            try
            {
                if (totalSumaProductos >= 0 && totalSumaProductos <= 999.99)
                {
                    descuento = 0;
                }
                else if (totalSumaProductos >= 1000 && totalSumaProductos <= 4999.99)
                {
                    descuento = totalSumaProductos * 0.10;
                }
                else if (totalSumaProductos >= 5000 && totalSumaProductos <= 9999.99)
                {
                    descuento = totalSumaProductos * 0.0;
                }
                else if (totalSumaProductos >= 10000)
                {
                    descuento = totalSumaProductos * 0.30;
                }
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            producto1 = 0;
            producto2 = 0;
            producto3 = 0;
            descuento = 0;
            subTotal = 0;
            totalPagar = 0;
        }
    }
}
