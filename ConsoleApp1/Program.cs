using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static List<Models> models = new List<Models>();
        public static List<Car> cars = new List<Car>();

        static void Main(string[] args)
        {      
            Models model1 = new Models("Lamborghini", 10f);
            Models model2 = new Models("Mercedes", 2f);
            Models model3 = new Models("Fiat", 3f);
            Models model4 = new Models("Renault", 4f);

            models.Add(model1);
            models.Add(model2);
            models.Add(model3);
            models.Add(model4);

            // TODO: Check id is not implemented
            Car lambo = new Car("Lamborghini", 1);
            Car lambo2 = new Car("Lamborghini", 2);
            Car lambo3 = new Car("Lamborghini", 3);

            Car mercedes = new Car("Mercedes", 4);
            Car mercedes2 = new Car("Mercedes", 5);
            Car mercedes3 = new Car("Mercedes", 6);

            Car fiat = new Car("Fiat", 7);
            Car fiat2 = new Car("Fiat", 7);
            Car fiat3 = new Car("Fiat", 7);

            Car renault = new Car("Renault", 10);
            Car renault2 = new Car("Renault", 10);
            Car renault3 = new Car("Renault", 10);

            cars.Add(lambo);
            cars.Add(lambo2);
            cars.Add(lambo3);
            cars.Add(mercedes);
            cars.Add(mercedes2);
            cars.Add(mercedes3);
            cars.Add(fiat);
            cars.Add(fiat2);
            cars.Add(fiat3);
            cars.Add(renault);
            cars.Add(renault2);
            cars.Add(renault3);

            // get all lamborghini cars
            List<int> result = RequestCarId("Lamborghini");

            // get 2 lamborghini cars
            List<int> result1 = RequestCarId(2, "Lamborghini");

            // get 4 mercedes cars
            List<int> result2 = RequestCarId(4, "Mercedes");

            PrintList(result);
            PrintList(result1);
            PrintList(result2);
        }

        private static void PrintList(List<int> result2)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            for (int i = 0; i < result2.Count; i++) {
                if (result2[i] == -1)
                {
                    Console.WriteLine("There weren't as many cars in the list as you asked for.");
                }
                else {
                    Console.WriteLine(string.Format("Found car with id {0}", result2[i].ToString()));
                }
                
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
        }

        /// <summary>
        /// - If there aren't as much cars as requested, the method returns as much cars as it finds and adds an -1 to the list
        /// - If there is no "count" parameter specified, the search returns ALL car ids which it can find within that model.
        /// 
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static List<int> RequestCarId(string searchString) {
            List<int> result = new List<int>();

            for (int i = 0; i < cars.Count; i++) {
                for (int j = 0; j < models.Count; j++) {
                    // model is being searched
                    if (cars[i].model == searchString)
                    {
                        // there is a model with that name
                        if (models[j].modelName == searchString)
                        {
                            result.Add(cars[i].id);
                        }
                    }
                    else {
                        continue;
                    }
                }
            }


            return result;
        }

        public static List<int> RequestCarId(int count, string searchString)
        {
            List<int> result = new List<int>();
            int tempCounter = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                for (int j = 0; j < models.Count; j++)
                {
                    if (tempCounter < count) {
                        // model is being searched
                        if (cars[i].model == searchString)
                        {
                            // there is a model with that name
                            if (models[j].modelName == searchString)
                            {
                                result.Add(cars[i].id);
                                tempCounter++;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    
                }
            }

            if (tempCounter < count) {
                result.Add(-1);
            }

            return result;
        }
    }
}
