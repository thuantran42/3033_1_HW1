// Thuan (Trae) Tran ID: 113437456
// MIS 3033 HW 1 Task 1

/* 
  You will be creating a console application to help our sales associates sell our main 
products, cogs and gears.  Cogs have a whole sale price of $79.99 and gears have a 
whole sale price of $250.00. 

When our sales associates are selling to our customers on 
the floor, we have a standard 15% markup on our wholesale price for our sales 
price.  However, if the customer purchases more than 10 of either item or a combined 
quantity of 16 items we only markup the items by 12.5%.  On top of this, the sales tax 
for all sales is 8.9%.

- Create a console application that will prompt the sales associate for the number 
of cogs as well as the number of gears for a sales order.  
-Create constant variables for the whole sale prices for the items as well as the 
markup percentages.  
- Once the user has input all of the data, create a receipt and 
display the total cost 
for the items, 
the discount amount,
the sales tax amount as
well as the grand total.  
 */

Console.WriteLine("Number of cogs?");// Prompt
double numCogs = Convert.ToDouble(Console.ReadLine()); // convert to int


Console.WriteLine("Number of gears?");
double numGears = Convert.ToDouble(Console.ReadLine()); // convert to int

const double cogPrice = 79.99; // constant doubles
const double gearPrice = 250.00;
const double markUpPerc = 0.15; // 15 %
const double comboMarkUpPerc = 0.125; // 12.5 % if customer purchase more than 10 of EITHER or combined of 16 items
const double salesTax = 0.089; // Sales tax is 8.9%


double combinedCount = numGears + numCogs; // combined count check

if ((numCogs > 10 || numGears > 10) || (combinedCount == 16)) // if there are more than 10 cogs or gears or combined count (16)
{                                                              // only mark up the items by 12.5%
    
    double comboTotal = (cogPrice * numCogs) + (gearPrice * numGears) ; //subtotal 
    double calcComboMarkUp = comboTotal * comboMarkUpPerc; // with combo mark up %
    double taxComboAmount = comboTotal * salesTax; // calculating tax amount
    double grandTotal = comboTotal + calcComboMarkUp + taxComboAmount;


    Console.WriteLine("Your receipt is");
    Console.WriteLine("You have bought a number of {0} cogs.", numCogs);
    Console.WriteLine("You have bought a number of {0} gears.", numGears);
    Console.WriteLine("Subtotal is {0:C2}", comboTotal); // total cost before taxes
    Console.WriteLine($"Discount amount is {calcComboMarkUp:C2}"); // Percent format
    Console.WriteLine("Sales tax is {0:C2}", taxComboAmount);
    Console.WriteLine($"The grand total is {grandTotal:C2}");
}
else // 15% mark up
{
    
    double regularTotal = (cogPrice * numCogs) + (gearPrice * numGears);  // subtotal
    double calcRegularMarkUp = regularTotal * markUpPerc; // with regular mark up %
    double taxRegularAmount = regularTotal * salesTax; // calculating tax amount
    double grandTotal = regularTotal + calcRegularMarkUp + taxRegularAmount;

    Console.WriteLine("Your receipt is");
    Console.WriteLine("You have bought a number of {0} cogs.", numCogs);
    Console.WriteLine("You have bought a number of {0} gears.", numGears);
    Console.WriteLine("Subtotal is {0:C2}", regularTotal); // subtotal
    Console.WriteLine($"Discount amount is {calcRegularMarkUp:C2}"); // Percent format
    Console.WriteLine("Sales tax is {0:C2}", taxRegularAmount);
    Console.WriteLine($"The grand total is {grandTotal:C2}");
}


