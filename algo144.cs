using System;
using System.Linq;
using System.Collections.Generic;


namespace HelloWorld
{
    class Program
    {
        internal interface ITrafficLight
        {
            bool IsAmberOn { get; }
            bool IsGreenOn { get; }
            bool IsRedOn { get; }
            void Set(State state);
        }

        internal enum State
        {
            Standby = 0,
            Red = 1,
            RedAmber = 2,
            Green = 3,
            Amber = 4
        }

        public void Set(State state)
        {
            throw new NotImplementedException();
        }

        internal class TrafficLight : ITrafficLight
        {
            public bool IsAmberOn => state == State.RedAmber || state == State.Amber;
            public bool IsGreenOn => state == State.Green;
            public bool IsRedOn => state == State.Standby || state == State.Red || state == State.RedAmber;
            public void Set(State state) => this.state = state;
            private State state = State.Standby;
        }

        static void Main(string[] args)
        {
            ITrafficLight trafficLight = new TrafficLight();

            // Durumu ayarla ve durumu kontrol et
            trafficLight.Set(State.Red);
            Console.WriteLine($"Red Light: {trafficLight.IsRedOn}, Amber Light: {trafficLight.IsAmberOn}, Green Light: {trafficLight.IsGreenOn}");

            trafficLight.Set(State.Green);
            Console.WriteLine($"Red Light: {trafficLight.IsRedOn}, Amber Light: {trafficLight.IsAmberOn}, Green Light: {trafficLight.IsGreenOn}");

        }
    }
}

