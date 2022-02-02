using System;
using System.Collections.Generic;

namespace TriangleTracker.Models
{
  public class Triangle
  {
    public int SideOne { get; set; }
    public int SideTwo { get; set; }
    public int SideThree { get; set; }

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }

    public string TypeOfTriangle()
    {
      if (SideOne > SideTwo + SideThree || SideTwo > SideOne + SideThree || SideThree > SideOne + SideTwo)
      {
        return "Not a Triangle";
      }
      else
      {
        if (SideOne == SideTwo && SideOne == SideThree)
        {
          return "Equilateral Triangle";
        }
        else if (SideOne == SideTwo || SideTwo == SideThree || SideOne == SideThree)
        {
          return "Isosceles Triangle";
        }
        else
        {
          return "Scalene Triangle";
        }
      }
    }
  }
}