namespace Desafio01 {
    public static class Utils {
        public static int CalculaTotalLetras(int numeroInicial, int numeroFinal) {

            int _totalLetras = 0;

            // Se necessário troca os valores do numeroInicial e numeroFinal
            // para garantir a sequencia do menor para o maior
            if (numeroFinal < numeroInicial) {
                numeroFinal += numeroInicial;
                numeroInicial = numeroFinal - numeroInicial;
                numeroFinal -= numeroInicial;
            }

            for (int i = numeroInicial; i <= numeroFinal; i++) _totalLetras += QdeDeCaracteresDoNumero(i);
            return _totalLetras;
        }
        /// <summary>
        /// Calcula a quantidade de caracteres de um número cardinal 
        /// </summary>
        /// <param name="numero">número inteiro</param>
        /// <returns></returns>
        public static int QdeDeCaracteresDoNumero(int numero) {

            return ParaNumCardinal(numero).Length;

        }

        /// <summary>
        /// Converte um número ordinal (de 0-100) para número cardinal
        /// </summary>
        /// <param name="numero">número inteiro</param>
        /// <returns></returns>
        public static string ParaNumCardinal(int numero) {

            //cria vetores de números cardinais para  referência de tradução
            //unidades -> vetores dos números  de  0 a  9
            //teens ----> vetores de  dezenass de 10 a 19
            //inteEntas-> vetores de  dezenas  de 20 a 90 
            string[] unidades = new string[] { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            string[] teens = new string[] { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] inteEntas = new string[] { "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };


            //tradução do numero ordinal para número cardinal
            string dec = "";
            string conector = "";
            string und = "";

            if (numero == 100) {
                return "cem";

            } else if (numero < 10) {
                und = unidades[numero];

            } else if (numero < 20) {
                dec = teens[numero - 10];

            } else if (numero < 100) {

                dec = inteEntas[numero / 10 - 2];
                if (numero % 10 == 0) {
                    conector = "";
                    und = "";
                } else {
                    conector = " e ";
                    und = unidades[numero % 10];
                }
            }
            return dec + conector + und;
        }
    }
}
