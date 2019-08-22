using System;

namespace Desafio01 {
    class Program {
        static void Main(string[] args) {

            //instancia objetos para receber os valores do formulário de entrada
            Intervalo inicial = new Intervalo();
            Intervalo final = new Intervalo();

            //Mensagens Iniciais 
            #region Instruções de Utilização
            Console.WriteLine("Cálculo do total de caracteres por intervalo: 0-100");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Ex.: No intervalo dos valores de 1 a 5, temos os números cardinais:");
            Console.WriteLine("um (2 caracteres), dois (4 caracteres), três, quatro e cinco");
            Console.WriteLine("Logo, o total de caracteres nesse intervalo é dado por:");
            Console.WriteLine("2 + 4 + 4 + 6 + 5 = 21");
            Console.WriteLine("-------------------------------------------------------------------");
            #endregion
            Console.WriteLine("Digite os Valores do Intervalo\n");

            //entrada de dados do formulario
            do Console.Write("Valor Inicial: "); while (!inicial.SetValor(Console.ReadLine(),0,100));
            do Console.Write("Valor Final: "); while (!final.SetValor(Console.ReadLine(),0,100));

            //Retorna a qualtidade de caracteres dos números cardinais
            //do intervalo inicial ao final
            int TotalLetras = Utils.CalculaTotalLetras(inicial.Valor, final.Valor);

            //exibe mensagem com o resultado do processamento
            Console.WriteLine($"\nO Total de caracteres calculado para o intervalo de {inicial.Valor} a {final.Valor} é {TotalLetras}");

        }
    }
}
