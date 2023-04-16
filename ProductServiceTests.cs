using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

[TestClass]
public class ProductServiceTests
{
    [TestMethod]
    public void GetAllProducts_DebeRetornarProductos()
    {
        // Arrange
        var mockRepository = new Mock<IProductRepository>();
        mockRepository.Setup(repo => repo.GetAllProducts()).Returns(new List<Product>
        {
            new Product { Id = 1, Name = "Producto 1" },
            new Product { Id = 2, Name = "Producto 2" },
            new Product { Id = 3, Name = "Producto 3" }
        });

        var service = new ProductService(mockRepository.Object);

        // Act
        var result = service.GetAllProducts();

        // Assert
        Assert.AreEqual(3, result.Count());
    }

    [TestMethod]
    public void GetProductById_DebeRetornarProductoConId1()
    {
        // Arrange
        var mockRepository = new Mock<IProductRepository>();
        mockRepository.Setup(repo => repo.GetProductById(1)).Returns(new Product { Id = 1, Name = "Producto 1" });

        var service = new ProductService(mockRepository.Object);

        // Act
        var result = service.GetProductById(1);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Id);
        Assert.AreEqual("Producto 1", result.Name);
    }
}


// En este ejemplo, estamos probando dos métodos de la clase ProductService: GetAllProducts y GetProductById.

// En el método GetAllProducts, primero creamos un objeto Mock de la interfaz IProductRepository. Luego, configuramos el método GetAllProducts de la
//  interfaz para que devuelva una lista de tres productos de prueba. Después, creamos una instancia de la clase ProductService
//  con el objeto Mock y llamamos al método GetAllProducts en el bloque "Act". Finalmente, en el bloque "Assert", verificamos que el resultado sea una 
//  lista con tres elementos.

// En el método GetProductById, sucede algo similar. Se crea un objeto Mock de la interfaz IProductRepository y se configura el método GetProductById
//  para que devuelva un producto de prueba con un Id de 1. Se crea una instancia de la clase ProductService con el objeto Mock y se llama al método GetProductById
//  con un argumento de 1 en el bloque "Act". 