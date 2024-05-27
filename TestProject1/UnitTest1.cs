using projetodeCodigocalc;

namespace TestProject1
{
    public class UnitTest1
    {

        public Calculadora costruirClasse()
        {
            string data = "25/05/2024";
            Calculadora calc = new Calculadora("25/05/2024");

            return calc;
        }
        
        


        [Theory]
        [InlineData(1, 2 , 3)]
        [InlineData(4, 5, 9)]
        public void Testsomar(int val1, int val2, int resultado)
        {
            Calculadora calc = costruirClasse();

            int resultadocalculadora = calc.somar(val1, val2);

            Assert.Equal(resultado , resultadocalculadora);
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void Testmultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = costruirClasse();

            int resultadocalculadora = calc.multiplicar(val1, val2);

            Assert.Equal( resultado, resultadocalculadora);
        }


        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void Testdividir(int val1, int val2, int resultado)
        {
            Calculadora calc = costruirClasse();

            int resultadocalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadocalculadora);
        }


        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void Testsubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = costruirClasse();

            int resultadocalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadocalculadora);
        }

        [Fact]

        public void DividirPorZero()
        {
            Calculadora calc =  costruirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));

        }


        [Fact]

        public void TestaHistorico()
        {
            Calculadora calc = costruirClasse();

            calc.somar(2, 5);
            calc.somar(3, 7);
            calc.somar(2, 8);
            calc.somar(5, 9);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);

        }
    }
}