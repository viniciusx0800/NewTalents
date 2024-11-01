namespace NewTalentsTest;

using System.ComponentModel;
using NewTalents;
using Xunit;


public class UnitTest1
{

    public Calculadora construirClass()
    {
        string data = "01/11/2024";
        Calculadora calc = new Calculadora("01/11/2024");

        return calc;
    }



    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(5, 5, 0)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(5, 5, 1)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClass();

        int resultadoCalculadora = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    // [Fact]
    // public void TestarDivisaoPorZero()
    // {
    //     Calculadora calc = new Calculadora();

    //      Assert.Trows<DivideByZeroException>(() => calc.Dividir(3, 0));

    // }
    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClass();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClass();

        calc.Somar(8, 3);
        calc.Somar(6, 3);
        calc.Somar(1, 9);
        calc.Somar(78, 3);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
        
    }

}
