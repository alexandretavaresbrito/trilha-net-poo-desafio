namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, int Memoria, string Imei, string Modelo) : base(Numero, Memoria, Imei, Modelo)
        {
        }
        // DONE: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Acessndo AppStore e instalando {nomeApp} no iPhone modelo {Modelo}");
        }
    }
}