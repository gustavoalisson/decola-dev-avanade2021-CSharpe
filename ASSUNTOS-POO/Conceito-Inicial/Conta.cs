using System;


namespace AprendendoCSharpe.ASSUNTOS_POO.Conceito_Inicial
{
    // modificador public: classe está visível a outras classes
    public class Conta
    {
        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; set; }

        // Criação dos metodos
        // void = O metodo não tem retorno
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {

           double saldoDisponivel = ConsultaSaldoDisponivel();
           if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saque indisponível.");
                return false;
            }
            else
            {
                this.Saldo -= valor;
                return true;
            }
         
          
        }

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }
}
