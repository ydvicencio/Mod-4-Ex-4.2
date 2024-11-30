using System;

class Program {
  static void Main() {
    //initialize total sales per person
    double danielleSales = 0, edwardSales = 0, francisSales = 0;
    double saleAmount;
    string input;
    

    while (true)
    {
      //get salesperson initial
      Console.Write("\nEnter salesperson initial (D, E, F) or 'Z' to quit: ");
      input = Console.ReadLine();

      //exit if input is 'Z'
      if (input.ToUpper() == "Z")
      {
        break;
      }

      //ensure input is valid initial
      if (input.Length != 1 || !"DEF" .Contains(input.ToUpper()))
      {
        Console.WriteLine("Invalid initial. Please try again.");
        continue;
      }

      //get sale amount
      Console.WriteLine("Enter sale amount: ");
      if (!double.TryParse(Console.ReadLine(), out saleAmount) || saleAmount < 0)
      {
        Console.WriteLine("Invalid sale amount. Please try again.");
        continue;
      }

      //add sale amount to corresponding person
      switch (input.ToUpper())
      {
        case "D":
          danielleSales += saleAmount;
          break;
        case "E":
          edwardSales += saleAmount;
          break;
        case "F":
          francisSales += saleAmount;
          break;
      }
      
    }

    //display total sales for each salesperson
    double grandTotal = danielleSales + edwardSales + francisSales;

    //display total sales for each salesperson
    Console.WriteLine("\nSales Summary:");
    Console.WriteLine($"Daniell's total sales: {danielleSales:C}");
    Console.WriteLine( $"Edward's total sales: {edwardSales:C}");
    Console.WriteLine( $"Francis's total sales: {francisSales:C}");
    Console.WriteLine($"\nGrand total sales: {grandTotal:C}");

    //determine and display the salesperson with the highest sales
    string topSalesperson = "None";
    double topSales = 0;

    if (danielleSales > topSales)
    {
      topSales = danielleSales;
      topSalesperson = "D";
    }
    if (edwardSales > topSales)
    {
      topSales = edwardSales;
      topSalesperson = "E";
    }
    if (francisSales > topSales)
    {
      topSales = francisSales;
      topSalesperson = "F";
    }

    Console.WriteLine($"Highest Sale: {topSalesperson}");
  }
}