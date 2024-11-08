namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public string Marca { get; set; }
        private string Modelo { get; set; }

        private string IMEI { get; set; }

        public int Memoria { get; set; }

        public Smartphone(string numero, string marca, string modelo, string imei, int memoria)
        {

            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

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