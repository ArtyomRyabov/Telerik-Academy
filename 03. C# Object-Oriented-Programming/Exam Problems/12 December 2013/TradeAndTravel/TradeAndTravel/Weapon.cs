﻿namespace TradeAndTravel
{
    using System.Collections.Generic;

    public class Weapon : Item
    {
        private const int GeneralWeaponValue = 10;

        public Weapon(string name, Location location = null)
            : base(name, Weapon.GeneralWeaponValue, ItemType.Weapon, location)
        {
        }
    }
}