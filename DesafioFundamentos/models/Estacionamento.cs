using System.Diagnostics.Contracts;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string PlacaEntrada = Console.ReadLine();
            veiculos.Add(PlacaEntrada);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");


            string PlacaSaida = Console.ReadLine();


            if (veiculos.Any(x => x.ToUpper() == PlacaSaida.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string Tempo = Console.ReadLine();
                int TempoConvert = Convert.ToInt32(Tempo);

                int horas  = TempoConvert;
                decimal valorTotal = precoInicial + precoPorHora * horas; 


                Console.WriteLine($"O veículo {PlacaSaida} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(PlacaSaida);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                
                for(int contador = 0; contador < veiculos.Count ; contador++)
                {
                    Console.WriteLine($"Veiculo {contador+1}:{veiculos[contador]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
