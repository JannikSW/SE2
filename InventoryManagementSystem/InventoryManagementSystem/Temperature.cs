namespace InventoryManagementSystem
{
    internal class Temperature
    {
        protected int minTemperature;
        protected int maxTemperature;
        protected string dimension;

        int degree;
        degreeOfCold coldness;

        public Temperature(int temperature)
        {
            this.degree = temperature;

            if (this.degree <= 0)
            {
                this.coldness = degreeOfCold.frozen;
            }
            if (0 < this.degree && this.degree > 15)
            {
                this.coldness = degreeOfCold.chilled;
            }
            if (15 <= this.degree)
            {
                this.coldness = degreeOfCold.room;
            }
        }

        public string coldnessString()
        {
            switch (coldness)
            { 
                case degreeOfCold.frozen:
                    return "frozen";
                case degreeOfCold.chilled:
                    return "chilled";
                case degreeOfCold.room:
                    return "room";
                default:
                    return "";
            }
        }
    }
}
