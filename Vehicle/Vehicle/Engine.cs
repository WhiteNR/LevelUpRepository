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
        private bool _isOverHeated;

        public Engine()
        {
            _isOverHeated = false;
            _currentTemperature = 92;
            _maxTemperature = 120;
        }

        public Engine(int maxTemperature)
        {
            _isOverHeated = false;
            _currentTemperature = 92;
            _maxTemperature = maxTemperature;
        }

        public void TryIncreaseSpeed(int maxSpeed,ref int currentSpeed, int increaseSpeed)
        {
            if (_isOverHeated)
            {
                CoolingEngine();
            }

            if (_currentTemperature < _maxTemperature && !_isOverHeated)
            {
                if (currentSpeed + increaseSpeed < maxSpeed)
                {
                    CoolingEngine();
                    currentSpeed += increaseSpeed;
                }
                else if (currentSpeed == maxSpeed)
                {
                    _currentTemperature += 5;
                    throw new Exception("Max speed is reached. Engine temperature is:" + _currentTemperature + " (engine will overheat on " + _maxTemperature + ") ");
                }
                else
                {
                    currentSpeed = maxSpeed;
                }
            }
            else
            {
                _isOverHeated = true;
                throw new Exception("Engine overheated!!!! Engine temperature is:" + _currentTemperature);
            }
        }

        public void TryDecreaseSpeed(int maxSpeed,ref int currentSpeed, int decreaseSpeed)
        {
            CoolingEngine();
            if (_isOverHeated)
            {
                throw new Exception("Engine overheated!!!! Engine temperature is:" + _currentTemperature);
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
            CoolingEngine();
            if (_isOverHeated)
            {
                throw new Exception("Engine overheated!!!! Engine temperature is:" + _currentTemperature);
            }
        }

        public void TryBreake( ref int currentSpeed)
        {
            CoolingEngine();
            if (_isOverHeated)
            {
                throw new Exception("Engine overheated!!!! Engine temperature is:" + _currentTemperature);
            }

            if (currentSpeed / 2 > 0)
            {
                currentSpeed -= currentSpeed / 2;
            }
            else
            {
                currentSpeed = 0;
            }
        }

        public void TryStop(ref int currentSpeed)
        {
            CoolingEngine();
            if (_isOverHeated)
            {
                throw new Exception("Engine overheated!!!! Engine temperature is:" + _currentTemperature);
            }

            currentSpeed = 0;
        }

        private void CoolingEngine()
        {
            if (_currentTemperature > 92)
            {
                _currentTemperature -= 5;
            }

            if (_currentTemperature < 92)
            {
                _isOverHeated = false;
                _currentTemperature = 92;
            }
        }

        public override string ToString()
        {
            return "Engine temperature: " + CurrentTemperature;
        }

        public int MaxTemperature { get { return _maxTemperature; } }
        public int CurrentTemperature { get { return _currentTemperature; } }
        public bool IsBroken { get { return _isOverHeated; } }
    }
}