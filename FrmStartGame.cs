using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GuessTheDish
{
    public partial class FrmStartGame : Form
    {
        private readonly List<FoodData> FoodDataList;

        public FrmStartGame()
        {
            InitializeComponent();
            FoodDataList = new List<FoodData>()
            {
                new FoodData(true, new List<string>() , "Lasanha"), new FoodData(false, new List<string>() , "Bolo de chocolate")
            };
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("O prato que você pensou é massa?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            var isPasta = result == DialogResult.Yes;
            var foods = FoodDataList
                .Where(x => x.IsPasta == isPasta)
                .OrderByDescending(x => x.Characteristics.Count)
                .ToList();

            NextQuestion(isPasta, foods, new List<string>());
        }

        private void GiveUp(bool isPasta, string supposedDish, List<string> existingCharacteristics)
        {
            string food = Interaction.InputBox("Qual prato você pensou?", "Desisto", "", 300, 300);

            //if (string.IsNullOrEmpty(food))
            //{
            //    MessageBox.Show("Por favor, forneça um nome de identificação válido para o prato.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    GiveUp(isPasta, supposedDish);
            //}
            //else

            Complete(isPasta, food, supposedDish, existingCharacteristics);
        }

        private void Complete(bool isPasta, string food, string supposedDish, List<string> existingCharacteristics)
        {
            string characteristic = Interaction.InputBox($"{food} é ________ mas {supposedDish} não", "Complete", "", 300, 300);

            //if (string.IsNullOrEmpty(characteristic))
            //{
            //    MessageBox.Show("Por favor, forneça características válidas para o prato.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Complete(isPasta, food, supposedDish);
            //}
            //else
            
            existingCharacteristics.Add(characteristic);

            FoodDataList.Add(new FoodData(isPasta, existingCharacteristics, food));
        }
    
        private bool NextQuestion(bool isPasta, List<FoodData> selectedFoods, List<string> existingCharacteristics)
        {
            bool stop = false;

            if(selectedFoods.Count() == 1)
            {
                var food = selectedFoods.First();

                DialogResult result = MessageBox.Show($"O prato que você pensou é {food.Name}?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    MessageBox.Show("Acertei de novo!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    GiveUp(food.IsPasta, food.Name, existingCharacteristics);

                return true;
            }
            else
            {
                for(int i = 0; i < selectedFoods.Count(); i++)
                {
                    for (int j = 0; j < selectedFoods[i].Characteristics.Count(); j++)
                    {
                        if (existingCharacteristics.Contains(selectedFoods[i].Characteristics[j]))
                            continue;

                        DialogResult result = MessageBox.Show($"O prato que você pensou é {selectedFoods[i].Characteristics[j]}?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            existingCharacteristics.Add(selectedFoods[i].Characteristics[j]);
                            var selectedOnes = selectedFoods.Where(x => existingCharacteristics.All(ec => x.Characteristics.Contains(ec)));
                            stop = NextQuestion(isPasta, selectedOnes.ToList(), existingCharacteristics);
                        }
                        else
                        {
                            var selectedOnes = selectedFoods.Where(x => !x.Characteristics.Contains(selectedFoods[i].Characteristics[j]) && existingCharacteristics.All(ec => x.Characteristics.Contains(ec)));
                            stop = NextQuestion(isPasta, selectedOnes.ToList(), existingCharacteristics);
                        }

                        if (stop)
                            break;
                    }

                    if (stop)
                        break;
                }
            }

            return stop;
        }
    }
}
