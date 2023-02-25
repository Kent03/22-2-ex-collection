using System;

namespace Cars
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            // Create a car model
            IModel model = new CarModel("Model S");

            // Create a car color
            IColor color = new CarColor("Red");

            // Create a car seat
            ISeat seat = new CarSeat(5);

            // Create a Tesla with a battery level of 50%
            ITesla tesla = new Tesla();
            IBattery battery = new CarBattery(50);

            // Start the car
            IStartStop startStop = new CarStartStop();
            startStop.Start();

            // Charge the Tesla
            tesla.Charge();

            // Get information about the car
            Console.WriteLine("Model: " + model.GetModel());
            Console.WriteLine("Color: " + color.GetColor());
            Console.WriteLine("Number of seats: " + seat.GetNumSeats());
            Console.WriteLine("Battery level: " + battery.GetBatteryLevel() + "%");

            // Stop the car
            startStop.Stop();
        }
    }
}
