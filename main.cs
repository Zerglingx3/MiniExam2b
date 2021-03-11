using System;

class MainClass {
  
  public static double DetermineHypotenuse (double side1, double side2){

    double hypotenuse = Math.Sqrt((side1 * side1) + (side2*side2));
    
    return hypotenuse;

  }
  
  
  public static void Main (string[] args) {
    
    Console.WriteLine("What is the length of side 1?");
    double side1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What is the length of side 2?");
    double side2 = Convert.ToDouble(Console.ReadLine());
    

    Console.WriteLine("The hypotenuse of this triangle is " + DetermineHypotenuse(side1, side2));

  }
}