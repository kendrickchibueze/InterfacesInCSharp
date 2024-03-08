namespace InterfacesInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mara's Kitchen....");
            Console.WriteLine();
            CanCook ck = new CanCook();
            ck.Ingredients = new string[] { "Maggi", "Mivina", "Crayfish", "salt", "RedOil", "Onions" };
            ck.startCooking("Silver Pot", "Rice", ck.Ingredients);

            /* string[] PraiseArray = new string[2] { "Gospel2", "Gospel3" };

             foreach(string content in PraiseArray)
             {
                 Console.WriteLine(content);
             }*/

           /* string[] newPraiseArray = { "Gospel2", "Gospel3", "Gospel4" };
            foreach (string content in newPraiseArray)
            {
                Console.WriteLine(content);
            }*/
           
        }
    }
}