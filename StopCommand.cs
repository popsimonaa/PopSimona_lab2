using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PopSimona_lab4.CustomCommands
{
    class StopCommand
    {
        private static RoutedUICommand launch_command;
        static StopCommand()
        {
            InputGestureCollection myInputGestures = new InputGestureCollection();
            launch_command = new RoutedUICommand("Launch", "Launch", typeof(StopCommand), myInputGestures);
            myInputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
        }
        public static RoutedUICommand Launch
        {
            get
            {
                return launch_command;
            }
        }
    }
}
