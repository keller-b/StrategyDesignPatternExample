using System;

namespace SOLID
{
    /// <summary>
    /// The Strategy abstract class, which defines an interface common to all supported strategy algorithms.
    /// </summary>
    abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }
}