using SlimDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebinder_Core
{
    /// <summary>
    /// The TabMateDevice class is derived from the DirectInput device class. It will handle finding a TabMate device, along with raising events to hook into.
    /// </summary>
    public class TabMateDevice
    {
        //Microsoft.DirectX.DirectInput.Device Tabmate;

        /// <summary>
        /// This is the timer that fires to capture button presses.
        /// </summary>
        public System.Timers.Timer event_timer = new System.Timers.Timer();

        /// The target "joystick"- the TabMate
        SlimDX.DirectInput.Joystick tab_mate;

        public TabMateDevice()
        {
            // Find the device
            /// The DirectInput interface
            SlimDX.DirectInput.DirectInput input = new SlimDX.DirectInput.DirectInput();
            
            /// For every device connected using DirectInput that:
            /// -   is a "game controller"
            /// -   and is connected
            foreach (DeviceInstance device in input.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                /// Get the TabMate from the input interface, and bind its ref via the guid
                tab_mate = new Joystick(input, device.InstanceGuid);
                break;
            }

            event_timer.Elapsed += Event_timer_Elapsed;
            event_timer.Enabled = true;
            event_timer.Interval = 1;

        }

        private void Event_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            StickHandlerLogic(tab_mate);
        }

        void StickHandlerLogic(Joystick js)
        {
            //Enumerate a snapshot of the joystick
            JoystickState state = new JoystickState();
            tab_mate.Acquire();
            state = tab_mate.GetCurrentState();

            bool[] buttons = state.GetButtons();

            for (int button_num = 0; button_num < buttons.Length; button_num++)
            {
                if (buttons[button_num])
                {
                    Console.WriteLine("Button " + button_num + " was pressed!");
                }
            }
        }
    }
}
