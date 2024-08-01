using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DistanciaEDosPuntos.ViewModel
{
    partial class DistanciaViewModel : ObservableObject
    {
        [ObservableProperty]
        public string point1X;
        [ObservableProperty]
        public string point1Y;
        [ObservableProperty]
        public string point2X; 
        [ObservableProperty]
        public string point2Y;
        [ObservableProperty]
        public string x1;
        [ObservableProperty]
        public string x2;
        [ObservableProperty]
        public string y1;
        [ObservableProperty]
        public string y2;
        [ObservableProperty]
        public string resultado;


        [RelayCommand]
        private void CalculateDistanceee()
        {
            // Obtener las coordenadas desde los campos de entrada
            if (double.TryParse(Point1X, out double point1X) &&
                double.TryParse(Point1Y, out double point1Y) &&
                double.TryParse(Point2X, out double point2X) &&
                double.TryParse(Point2Y, out double point2Y))
            {
                // Calcular la distancia entre los dos puntos
                double distance = CalculateDistance(point1X, point1Y, point2X, point2Y);

                // Mostrar la distancia en la etiqueta
                Resultado = $"Distance: {distance:F2}";
            }
            else
            {
                // Mostrar un mensaje de error si los valores no son válidos
                Resultado = "Invalid input!";
            }
        }



      
        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            // Fórmula para calcular la distancia entre dos puntos
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
