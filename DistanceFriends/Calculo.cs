using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceFriends
{
    class Calculo
    {
        public double CalculoDistancia(double primeiraLatitude, double primeiraLongitude, double segundaLatitude, double segundaLongitude)
        {
            double dLat = this.toRadian(segundaLatitude - primeiraLatitude);
            double dLon = this.toRadian(segundaLongitude - primeiraLongitude);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(this.toRadian(primeiraLatitude)) * Math.Cos(this.toRadian(segundaLatitude)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            double d = 6371 * 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            return d;
        }

        private double toRadian(double val)
        {
            return (Math.PI / 180) * val;
        }
    }
}
