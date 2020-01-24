using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public int Year;
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise) 
        {
            EngineNoise = engineNoise;
        }

        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
        }
         
    }
}
