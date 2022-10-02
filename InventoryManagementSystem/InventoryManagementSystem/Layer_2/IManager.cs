﻿using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal interface IManager
    {
        internal void addElement(IInventoryElement element);

        internal void deleteElement(IInventoryElement element);

        internal string informationElement(IInventoryElement element);
    }
}
