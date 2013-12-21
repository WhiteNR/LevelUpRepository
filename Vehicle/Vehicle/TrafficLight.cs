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

        TrafficLightDelegate _trafficLightDelegate;
        Random _randomSwitchTime = new Random();
        int _switchTime;
        int _time;

        public TrafficLight(TrafficLightDelegate trafficLightDelegate)
        {
            _trafficLightDelegate = trafficLightDelegate;
            _switchTime = _randomSwitchTime.Next(9);
            _time = -1;
        }

        public bool TrafficLightWork()
        { 
            _time++;
            if (_time == _switchTime)
            {
                if (_trafficLightDelegate != null)
                {
                    _trafficLightDelegate.Invoke();
                }
                _switchTime = _randomSwitchTime.Next(10);
                _time = -1;
                return true;
            }
            return false;
        }
    }
}
