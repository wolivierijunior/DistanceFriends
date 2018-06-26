using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distancia entre amigos");

            List<ListaDistancia> listaAmigos = new List<ListaDistancia>();

            double distancia;

            Calculo calculo = new Calculo();

            //Amigo1
            distancia = calculo.CalculoDistancia(28.5418, 77.2314, -23.633773, -46.626198);

            listaAmigos.Add(new ListaDistancia()
            {
                Amigo = "Amigo1",
                Distancia = distancia
            });

            //Amigo2
            distancia = calculo.CalculoDistancia(28.5418, 77.2314, -22.783146, -50.307419);

            listaAmigos.Add(new ListaDistancia()
            {
                Amigo = "Amigo2",
                Distancia = distancia
            });

            //Amigo3
            distancia = calculo.CalculoDistancia(28.5418, 77.2314, -22.927824, -45.495572);

            listaAmigos.Add(new ListaDistancia()
            {
                Amigo = "Amigo3",
                Distancia = distancia
            });

            //Amigo4
            distancia = calculo.CalculoDistancia(28.5418, 77.2314, -27.646620, -48.670361);

            listaAmigos.Add(new ListaDistancia()
            {
                Amigo = "Amigo4",
                Distancia = distancia
            });

            //Amigo5
            distancia = calculo.CalculoDistancia(28.5418, 77.2314, -26.304516, -48.843380);

            listaAmigos.Add(new ListaDistancia()
            {
                Amigo = "Amigo5",
                Distancia = distancia
            });

            //Amigo6
            distancia = calculo.CalculoDistancia(28.5418, 77.2314, -22.240088, -42.054329);

            listaAmigos.Add(new ListaDistancia()
            {
                Amigo = "Amigo6",
                Distancia = distancia
            });

            var resultado = (from t in listaAmigos
                             orderby t.Distancia ascending
                             select t).Take(3);

            foreach (var item in resultado)
            {
                Console.WriteLine(item.Amigo + " mais proximo. Distancia " + item.Distancia);
            }

            Console.Read();
        }

        private class ListaDistancia
        {
            public string Amigo { get; set; }

            public double Distancia { get; set; }
        }
    }
}



