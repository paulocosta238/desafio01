using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Desafio01 {

    /// <summary>
    /// Realiza Testes de Unidade
    /// </summary>
    [TestClass]
    public class TesteUnidade {

        Intervalo valor = new Intervalo();
        
        [TestMethod]
        public void Intervalo_TestaValorMax_ForaDoIntervaloMax() {
            // Arrange
            bool resultadoAtual = valor.SetValor("101", 0, 100);

            // Act
            bool resultadoEsperado = false;

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);

        }

        [TestMethod]
        public void Intervalo_TestaValorMin_ForaDoIntervaloMin() {
            // Arrange
            bool resultadoAtual = valor.SetValor("-1", 0, 100);

            // Act
            bool resultadoEsperado = false;

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);

        }


    }
}
