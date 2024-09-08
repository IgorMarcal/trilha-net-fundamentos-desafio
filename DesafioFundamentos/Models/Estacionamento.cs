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
            string placa = Console.ReadLine();
            this.veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado ao estacionamento.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0; 
             
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                if(!int.TryParse(Console.ReadLine(),out horas))
                {
                    Console.WriteLine("Não foi possível salvar horas. Digite um numero inteiro");
                    Environment.Exit(1);
                }
                valorTotal = (horas * this.precoPorHora )+this.precoInicial;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"PLACA: {veiculo}");

                }
            } else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
