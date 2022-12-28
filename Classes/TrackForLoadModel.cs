using System;
using System.Collections.Generic;

namespace lab_3
{
    internal class TrackForLoadModel
    {
        public readonly string RegistrationNumber;
        public readonly int WheelsAmount;
        public readonly int BodyVolume;
        public int redRowColor;
        public int greenRowColor;
        public int blueRowColor;

        private Random rnd = new Random();

        public TrackForLoadModel()
        {
            RegistrationNumber = GenerateRandomRegistrationNumber();
            WheelsAmount = GenerateRandomWheelsAmount();
            BodyVolume = GenerateRandomBodyVolume();
            GenerateColumnColor();
        }

        public TrackForLoadModel(string RegistrationNumber, string WheelsAmount, string BodyVolume, string redRowColor, string greenRowColor, string blueRowColor)
        {
            this.RegistrationNumber = RegistrationNumber;
            this.WheelsAmount = Int32.Parse(WheelsAmount);
            this.BodyVolume = Int32.Parse(BodyVolume);
            this.redRowColor = Int32.Parse(redRowColor);
            this.greenRowColor = Int32.Parse(greenRowColor);
            this.blueRowColor = Int32.Parse(blueRowColor);
        }

        private string GenerateRandomRegistrationNumber()
        {
            var LettersForNumber = new List<string> { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х" };
            var Length = LettersForNumber.Count;

            return LettersForNumber[rnd.Next(0, Length)] + rnd.Next(0, 10).ToString() 
                + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString() + LettersForNumber[rnd.Next(0, Length)]
                + LettersForNumber[rnd.Next(0, Length)] + rnd.Next(1, 800).ToString();
        }

        private int GenerateRandomWheelsAmount()
        {
            return rnd.Next(1, 7);
        }

        private int GenerateRandomBodyVolume()
        {
            return rnd.Next(10, 20);
        }

        private void GenerateColumnColor()
        {
            redRowColor = rnd.Next(0, 255);
            greenRowColor = rnd.Next(0, 255);
            blueRowColor = rnd.Next(0, 255);
        }
    }
}
