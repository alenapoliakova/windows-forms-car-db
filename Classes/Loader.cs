using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;

namespace lab_3
{
    internal class Loader
    {
        public Dictionary<string, List<CarForLoadModel>> CarCache = new Dictionary<string, List<CarForLoadModel>>();
        public Dictionary<string, List<TrackForLoadModel>> TrackCache = new Dictionary<string, List<TrackForLoadModel>>();
        public int Progress = 0;

        private void LoadData(string fileName, string type, string modelName)
        {
            // Load data from file with serialized cars / tracks
            if (type == "car")
            {
                CarCache[modelName] = new List<CarForLoadModel>();
            }
            else
            {
                TrackCache[modelName] = new List<TrackForLoadModel>();
            }

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    if (s != null && s != "")
                    {
                        string[] data = s.Split(',');
                        if (type == "car")
                        {
                            // Load Car from file
                            var firstColumn = data[0];
                            var secondColumn = data[1];
                            var thirdColumn = data[2];
                            var redRowColor = data[3];
                            var greenRowColor = data[4];
                            var blueRowColor = data[5];
                            CarCache[modelName].Add(new CarForLoadModel(firstColumn, secondColumn, thirdColumn, redRowColor, greenRowColor, blueRowColor));
                        }
                        else if (type == "track")
                        {
                            // Load Track from file
                            var firstColumn = data[0];
                            var secondColumn = data[1];
                            var thirdColumn = data[2];
                            var redRowColor = data[3];
                            var greenRowColor =data[4];
                            var blueRowColor = data[5];
                            TrackCache[modelName].Add(new TrackForLoadModel(firstColumn, secondColumn, thirdColumn, redRowColor, greenRowColor, blueRowColor));
                        }
                    }
                }
            }
        }

        private void AddData(string CarBrand, string CarType, string firstColumn, string secondColumn, string thirdColumn, int color1, int color2, int color3)
        {
            // Serialize data from Object to file
            var randomFileName = @"C:\Users\Алёна\source\repos\lab-3\" + CarBrand + "_" + CarType;
            var data = firstColumn + "," + secondColumn + "," + thirdColumn + "," + color1 + "," + color2 + "," + color3;

            if (!File.Exists(randomFileName))
            {
                using (FileStream fs = File.Create(randomFileName))
                {
                }
            }

            using (StreamWriter w = File.AppendText(randomFileName))
            {
                w.WriteLine(data);
            }
            return;
        }

        public void Load(CarType BrandType, string BrandName)
        {
            // Load data to Progress Bar (In Main Form)
            Progress = 0;
            var randomFileName = @"C:\Users\Алёна\source\repos\lab-3\" + BrandName + "_" + BrandType.ToString().ToLower();
            if (File.Exists(randomFileName))
            {
                LoadData(randomFileName, BrandType.ToString().ToLower(), BrandName);
            }

            if (CarCache.ContainsKey(BrandName) && BrandType == CarType.CAR)
            {
                var Amount = CarCache[BrandName].Count;
                for (int i = 0; i < Amount; i++)
                {
                    Progress = (int)((i + 1) * 100 / Amount);
                    Thread.Sleep(new Random().Next(0, 500));
                }
                Progress = 100;
                return;
            }
            else if (TrackCache.ContainsKey(BrandName) && BrandType == CarType.TRACK)
            {
                var Amount = TrackCache[BrandName].Count;
                for (int i = 0; i < Amount; i++)
                {
                    Progress = (int)((i + 1) * 100 / Amount);
                    Thread.Sleep(new Random().Next(0, 500));
                }
                Progress = 100;
                return;
            }
            else  // Not contains
            {
                var Amount = new Random().Next(10, 21);
                switch (BrandType)
                {
                    case CarType.CAR:
                        var CarList = new List<CarForLoadModel>();
                        for (int i = 0; i < Amount; i++)
                        {
                            var model = new CarForLoadModel();
                            CarList.Add(model);
                            AddData(BrandName, "car", model.RegistrationNumber, model.MediaName, model.AirbagAmount.ToString(), model.redRowColor, model.greenRowColor, model.blueRowColor);
                            Progress = (int)((i + 1) * 100 / Amount);
                            Thread.Sleep(new Random().Next(0, 500));
                        }
                        Progress = 100;
                        CarCache[BrandName] = CarList;
                        break;
                    case CarType.TRACK:
                        var TrackList = new List<TrackForLoadModel>();
                        for (int i = 0; i < Amount; i++)
                        {
                            var track = new TrackForLoadModel();
                            AddData(BrandName, "track", track.RegistrationNumber.ToString(), track.WheelsAmount.ToString(), track.BodyVolume.ToString(), track.redRowColor, track.greenRowColor, track.blueRowColor);
                            Progress = (int)((i + 1) * 100 / Amount);
                            Thread.Sleep(new Random().Next(0, 500));
                        }
                        Progress = 100;
                        TrackCache[BrandName] = TrackList;
                        break;
                }
            }
            Thread.Sleep(500);
        }

        public int getProgress()
        {
            // Progress Bar using it for get progress and display progress to user
            return Progress;
        }
    }
}
