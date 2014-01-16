using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class TrafficLight
    {
        public delegate void TrafficLightDelegate();

        public enum TrafficLights
        { 
            Green,Yellow,Red
        }

        TrafficLightDelegate _trafficLightDelegate;
        Random _randomSwitchTime = new Random();
        int _switchTime;
        int _time;
        TrafficLights _trafficLights;

        public TrafficLight(TrafficLightDelegate trafficLightDelegate)
        {
            _trafficLightDelegate = trafficLightDelegate;
            _switchTime = _randomSwitchTime.Next(20);
            _time = -1;
            _trafficLights = TrafficLights.Green;
        }

        public bool TrafficLightWork()
        {
            if (_time != _switchTime && _trafficLights != TrafficLights.Yellow) { _time++; }

            if (_trafficLights == TrafficLights.Yellow)
            {
                _trafficLights = TrafficLights.Red;
                if (_trafficLightDelegate != null)
                {
                    _trafficLightDelegate.Invoke();
                }
                _switchTime = _randomSwitchTime.Next(20);
                _time = -1;
                return true;
            }
            else if (_time == _switchTime)
            {
                _trafficLights = TrafficLights.Yellow;
                if (_trafficLightDelegate != null)
                {
                    _trafficLightDelegate.Invoke();
                }
                _switchTime = _randomSwitchTime.Next(20);
                return true;
            }
            else
            {
                _trafficLights = TrafficLights.Green;
            }
            return false;
        }

        public TrafficLights Lights { get { return _trafficLights; } }
    }
}
