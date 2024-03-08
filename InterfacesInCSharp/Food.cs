namespace InterfacesInCSharp
{
    public abstract class Food
    {
        protected string[] _ingredients;
        protected string _pot;
        protected string _foodItem;

        public abstract void startCooking(string _pot, string _foodItem, string[] _ingredients);
    }

    public class CanCook : Food, IDine, IRest
    {

        public CanCook()
        {

        }

        public string[] Ingredients {
            get
            {
               return _ingredients;
            }
            set
            {
                _ingredients = value;
            }
        }

        public override void startCooking(string _pot, string _foodItem, string[] Ingredients)
        {

            Console.WriteLine("We added water to boil at the " + _pot);
            Thread.Sleep(2000);
            AddFoodItem(_foodItem);
            Thread.Sleep(3000);
            AddIngredients(Ingredients);
            Thread.Sleep(3000);
            Eating(_foodItem);
            Thread.Sleep(3000);
            WashDishes(_pot);
            Thread.Sleep(3000);
            goSleep();




        }

        private void AddIngredients(string[] Ingredients)
        {
            Console.WriteLine("Mara added the following ingredients: ");
            foreach (string ingred in Ingredients)
            {
                Console.WriteLine(ingred);
            }

            
        }

        private void AddFoodItem(string _foodItem)
        {
            Console.WriteLine("we have added the " + _foodItem + " foodItem");

        }

        public void Eating(string foodItem)
        {
            _foodItem = foodItem;
            Console.WriteLine("Wow, Mara is done cooking and she is enjoying the " + foodItem);

        }

        public void WashDishes(string pot)
        {
            _pot = pot;
            Console.WriteLine("Mara is now washing the dirty " + pot);
        }

        public void goSleep()
        {
            Console.WriteLine("And Mara went to the bed and started Snurring...!");
        }
    }


}
