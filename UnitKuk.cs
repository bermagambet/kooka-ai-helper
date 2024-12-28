using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class KukTests
{
    [TestMethod]
    public void Impregnate_Kookz()
    {
        // Arrange
        boolean impregnatable = false;
        string Kookz  = "Kuanyshbek Abdurazak";
      
        if(Kookz)
        impregnatable = true;

        // Act
        boolean pregnant = impregnatable;

        // Assert
        Assert.AreEqual(true, pregnant);
    }
}
