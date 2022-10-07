namespace InventoryManagementSystem.Layer_3
{
    public interface IManager
    {
        public void addElement(string[] element);

        public void deleteElement(string name);

        public string[] infoElement();

        public string[] infoShortElement();
    }
}
