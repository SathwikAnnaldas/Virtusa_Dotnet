using System; 
class Bill
{
    static void Main() 
    {
        
        Start:
        Console.WriteLine("Welcome to Annldas Shopping");
        Console.WriteLine("Please Select the MENU\n"); 
        Console.WriteLine("1.OREO SHAKE\n2.BUTTER SCOTCH SHAKE\n3.ROSE MILK\n4.STRABERRY SHAKE");  
        int oreo=0; 
        int butter=0; 
        int rose=0;
        int strab=0; 
        int totalcost=0;
        string choice=Console.ReadLine(); 
        switch(choice.ToUpper()) 
        {
            case "OREO":
            totalcost=totalcost+oreo+50; 
            break; 
            case "BUTTERSCOTCH": 
            totalcost=totalcost+butter+40;
            break; 
            case "ROSEMILK":
            totalcost=totalcost+rose+60;
            break; 
            case "STRABERRY":
            totalcost=totalcost+strab+40;
            break;
            default:
            Console.WriteLine("Invalid flavour {0}--Select another",choice); 
            break;
        } 
        Decide:
        Console.WriteLine("Do you want any other shake :  yes or No");
        string decision=Console.ReadLine(); 
        switch(decision.ToUpper()) 
        {
            case "YES": 
            goto Start; 
            case "NO":
            break; 
            default : 
            Console.WriteLine("Your choice {0}  is invalid!",decision);
            goto Decide; 
        } 
        Console.WriteLine("Thanks for Visiting -- Have a good day");
        Console.WriteLine("Your Total Bill is {0}",totalcost);     
    }
}
