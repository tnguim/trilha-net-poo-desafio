using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {

        public Iphone(string numero, int memoria, string imei, string modelo) : base(numero, memoria, imei, modelo) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na App Store do iPhone.");

        }
    }
}
