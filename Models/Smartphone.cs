namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public int Memoria { get; set; }
        public string IMEI { get; set; }
        public string Modelo { get; set; }

        public Smartphone(string numero, int memoria, string imei, string modelo)
        {
            Numero = numero;
            Memoria = memoria;
            IMEI = imei;
            Modelo = modelo;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}




