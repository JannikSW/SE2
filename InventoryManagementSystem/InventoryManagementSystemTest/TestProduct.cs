using InventoryManagementSystem.Layer_3;
using System.Numerics;
using Xunit.Sdk;
using Moq;
using System.Diagnostics.CodeAnalysis;
using System;
using System.Drawing;

namespace InventoryManagementSystemTest
{
    public class TestProduct
    {
        Mock<IInventoryElement> kategoryProduct;
        Mock<IInventoryElement> storageProduct;
        Mock<IInventoryElement> ownerProduct;

        public TestProduct()
        {            
            kategoryProduct = new Mock<IInventoryElement>();
            kategoryProduct.Setup(kategory => kategory.getElementShortInfo()).Returns("Lebensmittel");

            storageProduct = new Mock<IInventoryElement>();
            storageProduct.Setup(storage => storage.getElementShortInfo()).Returns("Kühlschrank");

            ownerProduct = new Mock<IInventoryElement>();
            ownerProduct.Setup(owner => owner.getElementShortInfo()).Returns("Jannik");
        }

        [Fact]
        public void Product_IsCorrect()
        {
            // Given
            string nameProduct = "Milch";
            Price priceProduct = new Price("35.55");
            DateTime storagedateProduct = DateTime.Parse("12/12/2020");
            string expectedResult = "Milch 35.55 12.12.2020 Lebensmittel Kühlschrank Jannik";

            // When
            IInventoryElement product = new Product(nameProduct, priceProduct, storagedateProduct, this.kategoryProduct.Object, this.storageProduct.Object, this.ownerProduct.Object);
            string result = product.getElementInfo();

            // Then
            Assert.Equal(expectedResult, result);
        }
    }
}