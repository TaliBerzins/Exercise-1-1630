// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dr. I Flooring Cost Estimator\n: ");
Console.Write("Please enter the length of floor: ");
int floorLength = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the width of floor: ");
int floorWidth = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the cost per square foot of flooring selected: ");
int sqFootCost = Convert.ToInt32(Console.ReadLine());

String dashes = new String( '-', 20);
Console.WriteLine(dashes);

const double feetPerHour = 40;
const double costPerHour = 40;
int floorSize = floorLength * floorWidth;
double floorCost = sqFootCost * floorSize;
double installationTime = floorSize / feetPerHour;
double installationCost = costPerHour * installationTime;

Console.WriteLine("With a total floor size of " + floorSize + " the flooring cost is $" + floorCost);
Console.WriteLine("It will take " + installationTime + " hours to install the floor at a cost of $" + installationCost + "\n");
Console.WriteLine("The total finished cost for the new floor is : $" + (installationCost + floorCost));




