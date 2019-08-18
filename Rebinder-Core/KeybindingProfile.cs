using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebinder_Core
{
    /// <summary>
    /// Keybinding Profile Manager handles the modification, saving, and loading of a file, as well as reporting what key is associated to a particular button pressed.
    /// 
    /// It's fairly generic.
    /// </summary>
    class KeybindingProfileManager
    {

        public KeybindingProfileManager()
        {

        }

        public bool save_profile()
        {
            throw NotImplementedException;
        }

        public bool load_profile()
        {
            throw NotImplementedException;
        }

        
    }

    class KeybindingProfile
    {
        List<Keybind> bindings;

        /// <summary>
        /// Converts the keybinding profile to a dictonary for mapping a key
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> export_profile_to_dictonary()
        {
            //  Create the dictionary goind out
            Dictionary<int, string> binding_dict = new Dictionary<int, string>();

            //  For every keybind in the profile
            foreach (Keybind keybind in bindings)
            {
                //  Add it to the outgoing dictionary
                binding_dict.Add(keybind.button_number, keybind.sendkey);
            }

            //  Return the dictionary
            return binding_dict;
        }

        /// <summary>
        /// Returns the sendkey string for the given button
        /// </summary>
        /// <param name="button_num"></param>
        /// <returns></returns>
        public string get_key(int button_num)
        {
            //  If the key exists in the list
            if (bindings.Exists(x => button_num.Equals(x.button_number)))
            {
                //  Return its keystroke
                return bindings.Where(x => button_num.Equals(x.button_number)).FirstOrDefault().sendkey;
            }
            //  Otherwise
            else
            {
                /// the key doesn't exist
                return null;
            }
        }

        /// <summary>
        /// Sets the value of a keypress to be sent to a particular button_number
        /// </summary>
        /// <param name="button_num"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool set_key(int button_num, string key)
        {
            //  If the key exists in the list
            if (bindings.Exists(x => button_num.Equals(x.button_number)))
            {
                //  Then update its sendkey
                bindings.Where(x => button_num.Equals(x.button_number)).FirstOrDefault().sendkey = key;

                /// and return a success
                return true;
            }
            //  Otherwise
            else
            {
                /// the key doesn't exist or it failed 
                return false;
            }
        }
    }

    /// <summary>
    /// Represents a single keybind.
    /// 
    /// In example, button 0 mapped to F2.
    /// </summary>
    class Keybind
    {
        /// <summary>
        /// The button number of the controller
        /// </summary>
        public int button_number { get; set; }

        /// <summary>
        /// The string representation of the key to send. Unprintable keys should be represented as instructed in the link below:
        /// 
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys?redirectedfrom=MSDN&view=netframework-4.8
        /// </summary>
        public string sendkey { get; set; }
    }
}
