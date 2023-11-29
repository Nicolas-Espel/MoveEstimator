using System;

class Program {
  public static void Main (string[] args) {
    const double BaseRate = 200;
    double hourlyRate = 150;
    double dollarPerMile = 2;

    Console.WriteLine("Welcome to Malcom Movers! Please enter how many hours your move will take:");
    double totalHours = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Great! Now please enter how many total miles the move will be: ");
    double totalMiles = Convert.ToDouble(Console.ReadLine()); 

    double totalMovingFee = (totalHours * hourlyRate) + (totalMiles * dollarPerMile) + BaseRate;

    Console.WriteLine("The total cost of your move will be: ${0:0.00}", totalMovingFee);
  }
}