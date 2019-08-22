using System;

namespace Desafio01 {

    /// <summary>
    /// Classe para manter o Intervalo de valores Inicial e Final 
    /// </summary>
    public class Intervalo : IValor {

        private int _valor = 0;

        /// <summary>
        /// retorna o valor após o SetValor ter sido validado
        /// </summary>
        public int Valor {
            get {
                return _valor;
            }
        }
        /// <summary>
        /// Atribui valor ao objeto validando aos parâmetros de entrada
        /// de acordo com os valores mínimo e máximo estabelescidos
        /// </summary>
        /// <param name="valorDigitado"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public bool SetValor(string valorDigitado, int min, int max) {

            if (valorDigitado == "") {

                Console.WriteLine("O campo é obrigatório! ");
                return false;

            } else {

                try {
                    _valor = int.Parse(valorDigitado);

                } catch (Exception) {

                    Console.WriteLine("Número Inválido! ");
                    return false;
                }
            }

            if (_valor < min || _valor > max) {
                Console.WriteLine($"valor fora do intervalo {min}-{max}!");
                return false;
            }

            return true;
        }
    }
}
