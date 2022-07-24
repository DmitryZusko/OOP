namespace Task_6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class MyArray
    {
        private List<double> InsideArr { get; set; }

        public void ReadFromFile(string inputPath)
        {
            var strFromFile = File.ReadAllText(inputPath);
            InsideArr = strFromFile.Split(',')
                .Select(x => Double.Parse(x))
                .ToList();
            if (InsideArr.Count() > 5)
            {
                throw new TooManyDataException("The input data exceeds 5 entries!");
            }
        }

        public string Print()
        {
            return String.Join(", ", InsideArr)
                .ToString();
        }
        public double GetMax() => InsideArr.Max();

        public double GetMin() => InsideArr.Min();

        public double GetAverage() => Math.Round(InsideArr.Average(), 3);

        public void WriteToFile(string outputPath)
        {
            File.WriteAllLines(outputPath, new[] { GetMax().ToString(), GetMin().ToString(), GetAverage().ToString() });
            Console.WriteLine("Data was saved in the file.");
        }

    }
}
