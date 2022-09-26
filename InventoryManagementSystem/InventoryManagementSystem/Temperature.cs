namespace InventoryManagementSystem
{
    class Temperature
    {
        enum degreeOfCold
        {
            frozen,
            chilled,
            room
        };

        int degree;
        degreeOfCold coldness;

        Temperature(int temperature)
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
                this.coldness = degreeOfCold.frozen;
            }
        }
    }
}
