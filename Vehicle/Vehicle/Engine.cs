using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Engine
    {
        private int _maxTemperature;
        private int _currentTemperature;
        private bool _isBroken;

        public Engine()
        {
            _isBroken = false;
            _currentTemperature = 80;
            _maxTemperature = 120;
        }

        public Engine(int maxTemperature)
        {
            _isBroken = false;
            _currentTemperature = 80;
            _maxTemperature = maxTemperature;
        }

        public void TryIncreaseSpeed(int maxSpeed,ref int currentSpeed, int increaseSpeed)
        {
            if (_currentTemperature < _maxTemperature && !_isBroken)
            {
                if (currentSpeed + increaseSpeed < maxSpeed)
                {
                    currentSpeed += increaseSpeed;
                }
                else if (currentSpeed == maxSpeed)
                {
                    _currentTemperature += 5;
                    throw new Exception("Max speed is reached. Engine temperature is:" + _maxTemperature.ToString() + " (engine blow up on " + _currentTemperature + ") ");
                }
                else
                {
                    currentSpeed = maxSpeed;
                }
            }
            else
            {
                _isBroken = true;
                throw new Exception("Engine blowed up!!!! ");
            }
        }

        public void TryDecreaseSpeed(int maxSpeed,ref int currentSpeed, int decreaseSpeed)
        {
            if (_isBroken)
            {
                throw new Exception("Engine blowed up!!!! ");
            }

            if (currentSpeed - decreaseSpeed > 0)
            {
                currentSpeed -= decreaseSpeed;
            }
            else
            {
                currentSpeed = 0;
            }
        }

        public void TryKeepCurrentSpeed()
        {
            if (_isBroken)
            {
                throw new Exception("Engine blowed up!!!! ");
            }
        }

        public override string ToString()
        {
            return "Engine temperature: " + CurrentTemperature;
        }

        public int MaxTemperature { get { return _maxTemperature; } }
        public int CurrentTemperature { get { return _currentTemperature; } }
        public bool IsBroken { get { return _isBroken; } }
    }
}