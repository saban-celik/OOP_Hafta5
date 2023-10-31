


using OOP_Hafta5;

class Program
{
    static void Main()
    {
        // Gezegenler, Ay'lar ve Roketlerin oluşturulması
        Planet earth = new Planet("Earth", 5.972e24, 6371e3, 0);
        Planet mars = new Planet("Mars", 6.39e23, 3389.5e3, 225e6);
        Moon moon = new Moon("Moon", 7.342e22, 1737.1e3, earth);
        Moon phobos = new Moon("Phobos", 1.0659e16, 11.1e3, mars);

        Rocket rocketToMoon = new Rocket("Rocket to Moon", 1000, 500, 4, 5000, 3000);
        Rocket rocketToMars = new Rocket("Rocket to Mars", 1500, 750, 6, 6000, 3500);

        // Roketlerin hareket ettirilmesi
        rocketToMoon.Launch();
        rocketToMoon.TravelTo(moon);
        rocketToMoon.Land();

        rocketToMars.Launch();
        rocketToMars.TravelTo(phobos);
        rocketToMars.Land();
    }
}
