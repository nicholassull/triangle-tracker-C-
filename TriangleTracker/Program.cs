using TriangleTracker.Models;
using System;


namespace TriangleTracker
{
  public class Program
  {
    public static void Main() {
      Console.WriteLine("Please input 3 sides to create a triangle!");
      int sideOne = int.Parse(Console.ReadLine());
      int sideTwo = int.Parse(Console.ReadLine());
      int sideThree = int.Parse(Console.ReadLine());
      Triangle newTriangle = new Triangle(sideOne, sideTwo, sideThree);
      Console.WriteLine(newTriangle.TypeOfTriangle());
    } 
  }
}
