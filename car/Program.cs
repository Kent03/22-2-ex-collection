namespace Cars
    //lehoangkhoi-20it438-20mc
{
    // Interface model xe
    public interface IModel
    {
        string GetModel();
    }

    // Interface màu sắc xe
    public interface IColor
    {
        string GetColor();
    }

    // Interface Khởi động và dừng xe
    public interface IStartStop
    {
        void Start();
        void Stop();
    }

    // Interface ghế ô tô
    public interface ISeat
    {
        int GetNumSeats();
    }

    // Interface cho các tính năng dành riêng cho Tesla
    public interface ITesla
    {
        void Charge();
    }

    // Interface pin
    public interface IBattery
    {
        int GetBatteryLevel();
    }

    // Abstract base cho xe
    public abstract class Car
    {
        public abstract string GetDescription();
    }

    // Concrete class for a car model
    public class CarModel : IModel
    {
        private string model;

        public CarModel(string model)
        {
            this.model = model;
        }

        public string GetModel()
        {
            return this.model;
        }
    }

    // Concrete class for a car color
    public class CarColor : IColor
    {
        private string color;

        public CarColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color;
        }
    }

    // Concrete class for starting and stopping the car
    public class CarStartStop : IStartStop
    {
        public void Start()
        {
            //xe bdau
        }

        public void Stop()
        {
            // xe dừng
        }
    }

    // Concrete class for car seats
    public class CarSeat : ISeat
    {
        private int numSeats;

        public CarSeat(int numSeats)
        {
            this.numSeats = numSeats;
        }

        public int GetNumSeats()
        {
            return this.numSeats;
        }
    }

    // Concrete class for Tesla-specific features
    public class Tesla : ITesla
    {
        public void Charge()
        {
            // code to charge the Tesla
        }
    }

    // Concrete class for car batteries
    public class CarBattery : IBattery
    {
        private int batteryLevel;

        public CarBattery(int batteryLevel)
        {
            this.batteryLevel = batteryLevel;
        }

        public int GetBatteryLevel()
        {
            return this.batteryLevel;
        }
    }
}
