using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tadreb_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Singlton
            ////// Constructor is protected -- cannot use new
            ////Singleton s1 = Singleton.Instance();
            ////Singleton s2 = Singleton.Instance();

            ////// Test for same instance

            ////if (s1 == s2)
            ////{
            ////    Console.WriteLine("Objects are the same instance");
            ////}
            #endregion

            #region Factory Method
           
            ////FactoryMethod[] factory = new FactoryMethod[2];

            ////factory[0] = new ConcreteCreatorA();
            ////factory[1] = new ConcreteCreatorB();

            ////foreach (FactoryMethod creator in factory)
            ////{
            ////    Product product = creator.FactoryMethodFunc();
            ////    Console.WriteLine("Created {0}",product.GetType().Name);
            ////}

            #endregion

            #region Abstract Factory
            ////ContinentFactory africa = new AfricaFactory();
            ////AnimalWorld world = new AnimalWorld(africa);
            ////world.RunFoodChain();

            ////// Create and run the American animal world

            ////ContinentFactory america = new AmericaFactory();
            ////world = new AnimalWorld(america);
            ////world.RunFoodChain();

            #endregion

            #region Prototype
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors

            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;

            #endregion

            // Wait for user
            Console.ReadKey();
        }
    }
    
   
}
