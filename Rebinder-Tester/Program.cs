using Rebinder_Core;
using SlimDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rebinder_Tester
{
    class Program
    {
        //Joystick[] Sticks;

        //System.Timers.Timer timer1;

        static void Main(string[] args)
        {

            TabMateDevice tmd = new TabMateDevice();

            while (tmd.event_timer.Enabled)
            {

            }

            /*List<SlimDX.DirectInput.Joystick> sticks = new List<SlimDX.DirectInput.Joystick>();

            SlimDX.DirectInput.DirectInput Input = new DirectInput();
            SlimDX.DirectInput.Joystick stick;

            System.Timers.Timer timer1 = new System.Timers.Timer
            {
                Enabled = true,
                Interval = 1
            };

            timer1.Elapsed += timer1_Tick;

            foreach (DeviceInstance device in Input.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                // Creates a joystick for each game device in USB Ports
                try
                {
                    stick = new SlimDX.DirectInput.Joystick(Input, device.InstanceGuid);
                    stick.Acquire();

                    // Gets the joysticks properties and sets the range for them.
                    foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                    {
                        if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                            stick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                    }

                    // Adds how ever many joysticks are connected to the computer into the sticks list.
                    Sticks.Add(stick);
                }
                catch (DirectInputException)
                {
                }
            }
            Console.WriteLine(sticks.Count);
            //return sticks.ToArray();*/


        }

        /*private static void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //Creates the StickHandlingLogic Method which takes all the joysticks in the sticks List and puts them into a timer.
        public static void timer1_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            for (int i = 0; i < Sticks.Length; i++)
            {
                StickHandlingLogic(Sticks[i], i);
            }
        }

        void StickHandlingLogic(Joystick stick, int id)
        {
            // Creates an object from the class JoystickState.
            JoystickState state = new JoystickState();

            state = stick.GetCurrentState(); //Gets the state of the joystick

            //These are for the thumbstick readings
            /*yValue = -state.Y;
            xValue = state.X;
            zValue = state.Z;
            rotationZValue = -state.RotationZ;*/

            //bool[] buttons = state.GetButtons(); // Stores the number of each button on the gamepad into the bool] butons.
            //Here is an example on how to use this for the joystick in the first index of the array list
            /*if (id == 0)
            {
                // This is when button 0 of the gamepad is pressed, the label will change. Button 0 should be the square button.
                if (buttons[0])
                {
                    label1.Text = "Worked";
                }

            }
        }*/
    }
}
