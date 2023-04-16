using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_DebeRetornarLaSumaCorrecta()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 5;
        int b = 10;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Add_DebeManejarNumerosNegativos()
    {
        // Arrange
        var calculator = new Calculator();
        int a = -5;
        int b = 10;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Add_DebeManejarNumerosGrandes()
    {
        // Arrange
        var calculator = new Calculator();
        int a = int.MaxValue;
        int b = 1;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.AreEqual(int.MinValue, result);
    }
}


// Se utiliza el framework NUnit para escribir nuestras pruebas unitarias.
// La clase de pruebas se marca con el atributo [TestFixture] y cada método de prueba se marca con el atributo [Test].

// En la primera prueba, se prueba que el método Add calcule la suma correcta.
// En la segunda prueba, se prueba que el método maneje correctamente números negativos.
// En la tercera prueba, se prueba que el método maneje correctamente números grandes.