﻿namespace InventoryManagementSystem
{
    class Owner
    {
        string name;

        public Owner(string name)
        {
            this.name = name;
        }

        public string infoString()
        {
            return this.name;
        }
    }
}
