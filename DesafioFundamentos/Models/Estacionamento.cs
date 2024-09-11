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
            string placa;
            string opcao;

            //enquanto o usuário disser que Sim para cadastrar um veículo o laço continuará
            do{
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add(placa);

            Console.WriteLine("\nVeículo adicionado com sucesso! Deseja adicionar um novo veículo?\n"+
            "S (SIM) / N (NAO)?");

            opcao = Console.ReadLine();
            }
            while(opcao =="s" || opcao == "sim");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa;
            placa = Console.ReadLine();


            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                int horas = 0;
                decimal valorTotal = 0;

                //Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = int.Parse(Console.ReadLine());

                valorTotal = precoInicial + (precoPorHora * horas);                    

                //Remove a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"***************EXTRATO*************** \n PLACA........: {placa}\n VALOR/HORA...: R$ {precoPorHora}\n PERMANENCIA..: {horas} horas\n TOTAL........: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {

                Console.WriteLine("Os veículos estacionados são:");

                foreach (string valor in veiculos)
                {
                    Console.WriteLine(valor);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
//OBRIGADO DIO!