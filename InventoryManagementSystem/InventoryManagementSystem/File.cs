namespace InventoryManagementSystem
{
    abstract class Data
    {
        abstract protected saveData(File test);
        abstract protected File loadFile();
    }
}
