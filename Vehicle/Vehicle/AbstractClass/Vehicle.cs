using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public abstract class Vehicle : IVehicle
    {
        private readonly float _weight;
        private Engine _engine;
        private int _power;
        private int _maxSpeed;
        protected int _currentSpeed;

        public Vehicle()
        {
            _engine = new Engine();
            _weight = 0;
            _power = 10;
            _maxSpeed = 100;
            _currentSpeed = 0;
        }

        public Vehicle(float weight, int maxSpeed, int maxTemperature, int power)
        {
            _engine = new Engine(maxTemperature);
            _maxSpeed = maxSpeed;
            _weight = weight;
            _power = power;
            _currentSpeed = 0;
        }

        public Engine Engine
        {
            get { return _engine; }
        }

        public float Weight
        {
            get { return _weight; }
        }

        public virtual void Drive()
        {
            Console.WriteLine("Base drive");
        }

        public virtual void Stop()
        {
            try
            {
                _engine.TryStop(ref _currentSpeed);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void IncreaseSpeed()
        {
            try
            {
                _engine.TryIncreaseSpeed(_maxSpeed, ref _currentSpeed, _power);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void DecreaseSpeed()
        {
            try
            {
                _engine.TryDecreaseSpeed(_maxSpeed, ref _currentSpeed, _power);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void KeepCurrentSpeed()
        {
            try
            {
                _engine.TryKeepCurrentSpeed();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual void Breake()
        {
            try
            {
                _engine.TryBreake(ref _currentSpeed);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int CurrentSpeed { get { return _currentSpeed; } }
    }
}