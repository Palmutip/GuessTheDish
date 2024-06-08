using System.Collections.Generic;

namespace GuessTheDish
{
    public class FoodData
    {
        public FoodData(bool isPasta, List<string> characteristics, string name)
        {
            IsPasta = isPasta;
            Characteristics = characteristics;
            Name = name;
        }

        public bool IsPasta { get; set; }
        public List<string> Characteristics { get; set; }
        public string Name { get; set; }    
    }
}
