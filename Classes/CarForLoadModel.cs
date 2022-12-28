using System;
using System.Collections.Generic;

namespace lab_3
{
    internal class CarForLoadModel
    {
        public readonly string RegistrationNumber;
        public readonly string MediaName;
        public readonly int AirbagAmount;
        public int redRowColor;
        public int greenRowColor;
        public int blueRowColor;

        private Random rnd = new Random();

        public CarForLoadModel()
        {
            RegistrationNumber = GenerateRandomRegistrationNumber();
            MediaName = GenerateRandomMediaName();
            AirbagAmount = GenerateRandomAirbagAmount();
            GenerateColumnColor();
        }
        public CarForLoadModel(string RegistrationNumber, string MediaName, string AirbagAmount, string redRowColor, string greenRowColor, string blueRowColor)
        {
            this.RegistrationNumber = RegistrationNumber;
            this.MediaName = MediaName;
            this.AirbagAmount = Int32.Parse(AirbagAmount);
            this.redRowColor = Int32.Parse(redRowColor);
            this.greenRowColor = Int32.Parse(greenRowColor);
            this.blueRowColor = Int32.Parse(blueRowColor);
        }

        private string GenerateRandomRegistrationNumber()
        {
            var LettersForNumber = new List<string> { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х" };

            return rnd.Next(0, LettersForNumber.Count).ToString() + rnd.Next(0, 10).ToString()
                + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString() + rnd.Next(0, LettersForNumber.Count).ToString()
                + rnd.Next(0, LettersForNumber.Count).ToString() + rnd.Next(1, 800);
        }

        private string GenerateRandomMediaName()
        {
            var MediaBrand = new List<string> { "Pioner", "KENWOOD", "JVC", "EasyGo" };
            var ModelID = new List<string> { "L", "M", "N", "K" };

            return MediaBrand[rnd.Next(0, MediaBrand.Count)] + " " 
                + ModelID[rnd.Next(0, ModelID.Count)] + ModelID[rnd.Next(0, ModelID.Count)] + "-" + rnd.Next(1, 1000).ToString();
        }

        private int GenerateRandomAirbagAmount()
        {
            return rnd.Next(0, 5);
        }

        private void GenerateColumnColor()
        {
            redRowColor = rnd.Next(0, 255);
            greenRowColor = rnd.Next(0, 255);
            blueRowColor = rnd.Next(0, 255);
        }
    }
}
