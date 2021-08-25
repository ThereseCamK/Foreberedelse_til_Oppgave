using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Foreberedelse_til_Oppgave
{
    public class Car
    {
        public int _speedLimit;
        public int _speed { get; set; }
        public int _speedDiff { get; set; }

        public Car(int speed ,int speedLimit)
        {
            _speedLimit = speedLimit;
            _speed = speed;
        }

       

        public void SlowDown()
        {
            _speed -= 10;
            CheckSpeeding(_speed, _speedLimit);
        }

        public void DriveFaster()
        {
            _speed += 10;
            CheckSpeeding(_speed, _speedLimit);
        }
       

        public void CheckSpeeding(int speed, int speedLimit)
        {
            if (speed < speedLimit)
            {
                _speedDiff = speedLimit - speed;
                Console.WriteLine(SpeedingText(_speedDiff)); 
                DriveFaster();
            }
            if (speed > speedLimit)
            {
                _speedDiff = speed - speedLimit;
                Console.WriteLine(SpeedingText(_speedDiff));
                SlowDown();
            }

            if (speed == speedLimit)
            {
               _speedDiff =0;
                 Console.WriteLine(SpeedingText(_speedDiff)); 
            }
        }

        public string SpeedingText(int speedDiff)
        {
            var text = "";
            if (_speed < _speedLimit)
            {
                Thread.Sleep(5000);
                text = $"Du kjører I {_speed} km/t i {_speedLimit} Sona! \n" +
                $"Det er {speedDiff} km/t for sakte! Gas På, du lager kø!";
            }
            if (_speed > _speedLimit)
            {
                Thread.Sleep(5000);
                text = $"Du kjører I {_speed} km/t i {_speedLimit} Sona! \n" +
                       $"Det er {speedDiff} km/t for sakte! Gas På, du lager kø!";
            }
            
          if (_speed == _speedLimit) text = "Du kjører i Fartsgrensen";

            return text;
        }
    }
  
}
