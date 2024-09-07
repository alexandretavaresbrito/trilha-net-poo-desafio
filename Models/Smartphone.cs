namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, int memoria, string imei, string modelo)
        {
            // DONE: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Memoria = memoria;
            IMEI = imei;
            Modelo = modelo;
        }
        public string Numero { get; set; }
        protected int Memoria { get; set; }
        protected string IMEI { get; set; }
        protected string Modelo { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

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