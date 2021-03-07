using System;
using SampleClassification.Model;

namespace consumeModelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            // Add input data
            var input = new ModelInput()
            {
              Col0 = ""
            };
            while(control == true){
                Console.Write("Cümle giriniz ");  
                input.Col0 = Console.ReadLine();
                ModelOutput result = ConsumeModel.Predict(input);
                string sentiment = result.Prediction == "1" ? "Positive" : "Negative";
                Console.WriteLine($"Text: {input.Col0}\nSentiment: {sentiment}");
            }
     
        }
    }
}