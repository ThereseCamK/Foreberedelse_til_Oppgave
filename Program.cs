using System;

namespace Foreberedelse_til_Oppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car(30, 70);
           //var carsCurrentSpeed = car1.Speed = 90;
           //var currentSpeedLimit = car1.SpeedLimit = 70;

            car1.CheckSpeeding(car1._speed, car1._speedLimit);
      

        
        
        }
      
     
    }
}
