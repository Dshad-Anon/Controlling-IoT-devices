using Controlling_IoT_devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controlling_IoT_devices.IoTDevices
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is turned on.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light is turned off");
        }
    }
    public class LightTurningOn : ICommand
    {
        Light light;

        public LightTurningOn(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOn();
        }
    }
    public class LightTurningOff : ICommand
    {
        Light light;
        public LightTurningOff(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.TurnOff();
        }
    }
}
