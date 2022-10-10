namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo;
        private string Imei;
        private int Memoria;

        protected List<string> Aplicativos;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Aplicativos = new List<string>();
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

        public void ListarAplicativosInstalados()
        {
            if(Aplicativos.Count == 0){
                Console.WriteLine("Não há aplicativos instalados.");
            }
            else{
                Console.WriteLine("Aplicativos instalados: ");
                foreach (string app in Aplicativos){
                    Console.WriteLine("- " + app);
                }
            }
        }
    }
}