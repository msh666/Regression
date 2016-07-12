using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regression
{
    class FileProcessing
    {
        private string inputName;
        private string outputName;

        public string InputName
        {
            get { return inputName; }
            set { inputName = value; }
        }

        public string OutputName
        {
            get { return outputName; }
            set { outputName = value; }
        }

        public double[][] ReadFromFile(out double order)
        {
            int rows = 0;
            StreamReader sr = new StreamReader(inputName);
            order = double.Parse(sr.ReadLine());
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                rows++;
            }
            double[][] array = new double[rows][];
            string[] tmp = File.ReadAllLines(inputName);

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = convert(tmp[i + 1].Split(';'));
            }
                       
            sr.Close();
            return array;
        }

        private double[] convert (string[] tmp)
        {
            double[] data = new double[tmp.Length];
            int i = 0;
            foreach (string item in tmp)
            {
                data[i] = double.Parse(item);
                i++;
            }
            return data;
        }

        public void Write(double[] parameters, string regressionName)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputName, true))
            {
                file.WriteLine(regressionName);
                file.Write(parameters[0]);
                for (int i = 1; i < parameters.Length; i++)
                {
                    file.Write(";" + parameters[i]);
                }
                file.WriteLine();    
            }
        }
    }
}
