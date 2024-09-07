namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string Numero, int Memoria, string Imei, string Modelo) : base(Numero, Memoria, Imei, Modelo)
        {
        }
        // DONE: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Acessando Google Play e instalando {nomeApp} no Nokia modelo {Modelo}");
        }
    }
}