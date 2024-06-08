using System.Collections.Generic;

namespace GuessTheDish
{
    /// <summary>
    /// Model with dish properties
    /// </summary>
    public class FoodData
    {
        /// <summary>
        /// Model with dish properties
        /// </summary>
        public FoodData(bool isPasta, List<string> characteristics, string name)
        {
            IsPasta = isPasta;
            Characteristics = characteristics;
            Name = name;
        }

        /// <summary>
        /// The user answer of the first question
        /// </summary>
        public bool IsPasta { get; set; }

        /// <summary>
        /// Characteristics of the current object
        /// </summary>
        public List<string> Characteristics { get; set; }

        /// <summary>
        /// Name of the dish / food
        /// </summary>
        public string Name { get; set; }    
    }
}
