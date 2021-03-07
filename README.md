### Ml.net
##### program.cs
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
###### ModelInput.cs
  public class ModelInput
    {
        [ColumnName("col0"), LoadColumn(0)]
        public string Col0 { get; set; }


        [ColumnName("col1"), LoadColumn(1)]
        public string Col1 { get; set; }


    }
###### ModelOutput.cs
 public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public String Prediction { get; set; }
        public float[] Score { get; set; }
    }



