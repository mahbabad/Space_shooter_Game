using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShooter.Interfaces
{
    public interface IWeapon
    {
            float WeaponHeat { get; }
            bool IsOverheated { get; }



            bool CanShoot();
            bool TryShoot();
            void CoolDown(float deltaTime);
    }
}
