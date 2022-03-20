using System;

namespace JSONInventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "G:/Dotnet/JSONInventoryManagement/json1.json";

            FetchDataForRice fetchDataForRice = new FetchDataForRice();
            Rice data = fetchDataForRice.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].Name);
                Console.WriteLine(data.typesOfRice[i].Weight);
                Console.WriteLine(data.typesOfRice[i].Price);
                int value = data.typesOfRice[i].Weight * data.typesOfRice[i].Price;
                Console.WriteLine("The Value of "+ data.typesOfRice[i].Name +"Rice inventory is "+ value);

            }
            Console.WriteLine("------------------------");

            FetchDataForPulses fetchDataForPulses = new FetchDataForPulses();
            Pulses Pdata = fetchDataForPulses.Read(path);

            for (int i = 0; i < Pdata.typesOfPulses.Count; i++)
            {
                Console.WriteLine(Pdata.typesOfPulses[i].Name);
                Console.WriteLine(Pdata.typesOfPulses[i].Weight);
                Console.WriteLine(Pdata.typesOfPulses[i].Price);
                int value = Pdata.typesOfPulses[i].Weight * Pdata.typesOfPulses[i].Price;
                Console.WriteLine("The Value of " + Pdata.typesOfPulses[i].Name + "Pulses inventory is " + value);

            }
            Console.WriteLine("------------------------");
            FetchDataForWheats fetchDataForWheats = new FetchDataForWheats();
            Wheats wdata = fetchDataForWheats.Read(path);

            for (int i = 0; i < wdata.typesOfWheats.Count; i++)
            {
                Console.WriteLine(wdata.typesOfWheats[i].Name);
                Console.WriteLine(wdata.typesOfWheats[i].Weight);
                Console.WriteLine(wdata.typesOfWheats[i].Price);
                int value = wdata.typesOfWheats[i].Weight * wdata.typesOfWheats[i].Price;
                Console.WriteLine("The Value of " + wdata.typesOfWheats[i].Name + "Pulses inventory is " + value);

            }

        }
    }
}
