using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void  IsTriangle_SideOne_One()
    {
      Triangle testTriangle = new Triangle(1,1,1);
      Assert.AreEqual(1, testTriangle.SideOne);
    }
    [TestMethod]
    public void IsTriangle_SideTwo_Two()
    {
      Triangle testTriangle = new Triangle(1,2,1);
      Assert.AreEqual(2, testTriangle.SideTwo);
    }
    [TestMethod]
    public void IsTriangle_SideThree_Three()
    {
      Triangle testTriangle = new Triangle(1,1,3);
      Assert.AreEqual(3, testTriangle.SideThree);
    }
    [TestMethod]
    public void ValidTriangle_Validity_NotATriangleBecauseOfSideOne()
    {
      Triangle testTriangle = new Triangle(13, 4, 2);
      Assert.AreEqual("Not a Triangle", testTriangle.TypeOfTriangle());
    }
    [TestMethod]
    public void ValidTriangle_Validity_NotATriangleBecauseOfSideTwo()
    {
      Triangle testTriangle = new Triangle(4, 13, 2);
      Assert.AreEqual("Not a Triangle", testTriangle.TypeOfTriangle());
    }
    [TestMethod]
    public void ValidTriangle_Validity_NotATriangleBecauseOfSideThree()
    {
      Triangle testTriangle = new Triangle(4, 2, 13);
      Assert.AreEqual("Not a Triangle", testTriangle.TypeOfTriangle());
    }

    [TestMethod]
    public void TypeOfTriangle_IsEquilateral_IsEquilateral()
    {
      Triangle testTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual("Equilateral Triangle", testTriangle.TypeOfTriangle());
    }
    [TestMethod]
    public void TypeOfTriangle_IsIsosceles_IsIsosceles()
    {
      Triangle testTriangle = new Triangle(3, 3, 2);
      Assert.AreEqual("Isosceles Triangle", testTriangle.TypeOfTriangle());
    }
    [TestMethod]
    public void TypeOfTriangle_IsScalene_IsScalene()
    {
      Triangle testTriangle = new Triangle(3, 2, 1);
      Assert.AreEqual("Scalene Triangle", testTriangle.TypeOfTriangle());
    }
  }
}