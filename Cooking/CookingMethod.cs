using System;

namespace SOLID
{
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    class CookingMethod
    {
        private string Food;
        
        //  The context
        private CookStrategy _cookStrategy;
    
        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            _cookStrategy = cookStrategy;
        }
    
        public void SetFood(string name)
        {
            Food = name;
        }
    
        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}