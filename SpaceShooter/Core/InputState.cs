using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter.Core
{
    public class InputState
    {
        public bool IsMovingUp { get; private set; }


        public bool IsMovingDown { get; private set; }

        public bool IsMovingLeft { get; private set; }

        public bool IsMovingRight { get; private set; }

        public bool IsShooting { get; private set; }

        public bool IsPauseRequested { get; private set; }

        public void KeyDown(Keys key)
        {
            SetKeyState(key, true);
        }

        public void KeyUp(Keys key)
        {
            SetKeyState(key, false);
        }

        private void SetKeyState(Keys key, bool isPressed)
        {
            switch (key)
            {
                case Keys.Up:
                case Keys.W:
                    IsMovingUp = isPressed;
                    break;

                case Keys.Down:
                case Keys.S:
                    IsMovingDown = isPressed;
                    break;

                case Keys.Left:
                case Keys.A:
                    IsMovingLeft = isPressed;
                    break;

                case Keys.Right:
                case Keys.D:
                    IsMovingRight = isPressed;
                    break;

                case Keys.Space:
                    IsShooting = isPressed;
                    break;

                case Keys.Escape:
                    if (isPressed)
                        IsPauseRequested = true;
                    break;
            }
        }

        public void ConsumePauseRequest()
        {
            IsPauseRequested = false;
        }

        public void Reset()
        {
        IsMovingUp = false;
        IsMovingDown = false;
        IsMovingLeft = false;
        IsMovingRight = false;
        IsShooting = false;
        IsPauseRequested = false;
        }
    }
}
