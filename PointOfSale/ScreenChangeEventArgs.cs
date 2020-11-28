/*
 * Author: Brian Parks
 * Class name: ScreenChangeEventArgs.cs
 * Purpose: An event args used for new screen change events.
 */

using System.Windows.Controls;

namespace PointOfSale {

    public class ScreenChangeEventArgs {

        /// <summary>
        /// The new screen to display on the main board of the form.
        /// </summary>
        public UserControl _newScreen { get; private set; }

        /// <summary>
        /// Creats a new ScreenChangeEventArgs with the new control to be used for the screen change.
        /// </summary>
        /// <param name="newControl">The new UserControl to change the main screen too.</param>
        public ScreenChangeEventArgs(UserControl newControl) {
            this._newScreen = newControl;
        }
    }
}