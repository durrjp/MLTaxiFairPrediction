using System;
using TaxiFairPredictionML.Model;

namespace TaxiFairPrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            ModelInput input = new ModelInput()
            {
                Vendor_id = "CMT",
                Rate_code = 1,
                Passenger_count = 3,
                Trip_distance = 10.5f,
                Payment_type = "CRD"
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine(result.Score);
        }
    }
}
