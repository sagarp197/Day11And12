//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONInventoryManagement
{
    public class FetchDataForPulses
    {
        public Pulses Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {

                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Pulses>(json);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }

    public class FetchDataForRice
    {
        public Rice Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {

                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }

    public class FetchDataForWheats
    {
        public Wheats Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {

                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Wheats>(json);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }

}
