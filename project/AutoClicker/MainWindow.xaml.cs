using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using InputManager;
using MessageBox = System.Windows.MessageBox;

namespace AutoClicker
{
    public partial class MainWindow : Window
    {
        /*private Keys _CurrentHotkey = Keys.None;

        private bool _IsReadingKey = false;
        private bool _IsWorking = false;

        private System.Timers.Timer _ClickTimer = null;

        private uint _MouseEvent = 0;

        private delegate void ManageKeyPressCallback( VirtualKeyCode k );*/

        public MainWindow( )
        {
            InitializeComponent( );

            /*this.intervalUpDown.Value = 1.0;
            this.intervalUpDown.Text = "1";

            this.HookKeyboard( );*/
        }

        /*private void HookKeyboard( )
        {
            var keyboard = new LowLevelInput.Hooks.LowLevelKeyboardHook( );

            keyboard.OnKeyboardEvent += OnKeyboardEvent;
            keyboard.InstallHook( );
        }

        private void OnKeyboardEvent( VirtualKeyCode k, KeyState s )
        {
            if ( s != KeyState.Down )
            {
                return;
            }

            var d = new ManageKeyPressCallback( ManageKeyPress );

            this.Dispatcher.Invoke( d, new object[ ] { k } );
        }

        private void OnClickTimerEvent( object sender, ElapsedEventArgs e )
        {
            var coordX = (uint) System.Windows.Forms.Cursor.Position.X;
            var coordY = (uint) System.Windows.Forms.Cursor.Position.Y;

            mouse_event( _MouseEvent, coordX, coordY, 0, 0 );
        }

        private void HotkeyButton_Click( object sender, RoutedEventArgs e )
        {
            _IsReadingKey = !_IsReadingKey;

            if ( _IsReadingKey )
            {
                hotkeyButton.Content = "Presionar...";
                hotkeyButton.IsEnabled = false;
            }
        }

        private void ManageKeyPress( VirtualKeyCode k )
        {
            if ( _IsReadingKey )
            {
                _CurrentHotkey = k;
                _IsReadingKey = false;

                hotkeyButton.Content = k.ToString( );
                hotkeyButton.IsEnabled = true;
            }
            else if ( _CurrentHotkey == k )
            {
                if ( _IsWorking )
                {
                    _ClickTimer.Stop( );
                    _ClickTimer.Dispose( );

                    _ClickTimer = null;

                    leftClickRadioButton.IsEnabled = true;
                    rightClickRadioButton.IsEnabled = true;
                    intervalUpDown.IsEnabled = true;
                    hotkeyButton.IsEnabled = true;
                }
                else
                {
                    _ClickTimer = new System.Timers.Timer( );

                    _ClickTimer.Elapsed += OnClickTimerEvent;
                    _ClickTimer.Interval = Convert.ToDouble( intervalUpDown.Value ) * 1000.0;
                    _ClickTimer.Enabled = true;

                    _MouseEvent = (uint) ( Convert.ToBoolean( leftClickRadioButton.IsChecked )
                                      ? ( MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP )
                                      : ( MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP ) );

                    leftClickRadioButton.IsEnabled = false;
                    rightClickRadioButton.IsEnabled = false;
                    intervalUpDown.IsEnabled = false;
                    hotkeyButton.IsEnabled = false;
                }

                _IsWorking = !_IsWorking;
            }
        }*/
    }
}
