namespace Desafio01 {
    /// <summary>
    /// Interface com contrato de utilização de valores 
    /// </summary>
    interface IValor {

        int Valor { get;  }

        bool SetValor(string valorDigitado, int min, int max);
    }
}
