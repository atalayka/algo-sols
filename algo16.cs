public class RentalCar
{

    public static int RentalCarCost(int days)
    {

        const int pricePerDay = 40;
        int cost = days * pricePerDay;

        if (days >= 7)
        {
            cost -= 50;
        }
        else if (days >= 3)
        {
            cost -= 20;
        }

        return cost;

    }
}
using System.Linq;
public class RentalCar
{

    public static int RentalCarCost(int days)
    {
        const int pricePerDay = 40;

        // Calculate the discounts
        int discount = days >= 7 ? 50 : days >= 3 ? 20 : 0;

        // Calculate the total cost
        return (days * pricePerDay) - discount;
    }
}
