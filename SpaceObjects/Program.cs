using System;
using System.Collections.Generic;

namespace SpaceObjects
{
    // Enums put in the namespace to allow all classes to see them
    public enum Startype
    {
        YellowDwarf,
        White,
        BlueNeutron,
        RedGiant
    }
    public enum PlanetType
    {
        Terrestrial,
        Giant,
        Dwarf,
        Gas_Giant
    }


    class Program
    {
        static void Main(string[] args)
        {
            Star sun = new Star(1, "Sun", Startype.YellowDwarf, 5778);


            // Allocating all the planet with our data and telling them which star they are in orbit for
            Planet mercury = new Planet(2, "Mercury", PlanetType.Terrestrial, 4879, 1408, 88, sun);
            Planet venus = new Planet(3, "Venus", PlanetType.Terrestrial, 12104, -5832, 225, sun);
            Planet earth = new Planet(4, "Earth", PlanetType.Terrestrial, 12742, 24, 365, sun);
            Planet mars = new Planet(5, "Mars", PlanetType.Terrestrial, 6779, 24.6, 687, sun);
            Planet jupiter = new Planet(6, "Jupiter", PlanetType.Gas_Giant, 139822, 9.9, 4331, sun);
            Planet saturn = new Planet(7, "Saturn", PlanetType.Gas_Giant, 116460, 10.7, 10747, sun);
            Planet uranus = new Planet(8, "Uranus", PlanetType.Giant, 50724, -17.2, 30589, sun);
            Planet neptune = new Planet(9, "Neptune", PlanetType.Giant, 49244, 16.1, 59800, sun);


            // Allocating the moons to their repsective planets. 
            Moon luna = new Moon(10, "Luna", PlanetType.Dwarf, 3475, 708, 27.3, earth);
            Moon deimos = new Moon(11, "Deimos", PlanetType.Dwarf, 12.4, 30.3, 1.3, mars);
            Moon phobos = new Moon(12, "Phobos", PlanetType.Dwarf, 22.2, 7.7, 0.3, mars);
            Moon titan = new Moon(13, "Titan", PlanetType.Dwarf, 5150, 382.68, 16, saturn);
            Moon europe = new Moon(14, "Europe", PlanetType.Dwarf, 3122, 85.2, 3.55, jupiter);
            Moon ganymedes = new Moon(15, "Ganymedes", PlanetType.Dwarf, 5262, 171.7, 7.15, jupiter);
            Moon io = new Moon(16, "Io", PlanetType.Dwarf, 3642, 42.5, 1.77, jupiter);
            Moon mimas = new Moon(17, "Mimas", PlanetType.Dwarf, 396, 22.6, 0.94, saturn);

            //adding the moons to the planets lists
            earth.Moons.Add(luna);
            mars.Moons.Add(deimos);
            mars.Moons.Add(phobos);
            saturn.Moons.Add(titan);
            jupiter.Moons.Add(europe);
            jupiter.Moons.Add(ganymedes);
            jupiter.Moons.Add(io);
            saturn.Moons.Add(mimas);

            // adding planets to the suns lists
            sun.Planets.Add(mercury);
            sun.Planets.Add(venus);
            sun.Planets.Add(earth);
            sun.Planets.Add(mars);
            sun.Planets.Add(jupiter);
            sun.Planets.Add(uranus);
            sun.Planets.Add(neptune);



            Console.WriteLine(sun +"\n");
            Console.WriteLine(mercury);
            Console.WriteLine(venus);
            Console.WriteLine(earth);
            Console.WriteLine(mars);
            Console.WriteLine(jupiter);
            Console.WriteLine(saturn);
            Console.WriteLine(uranus);
            Console.WriteLine(neptune);

            Console.WriteLine("\nDistance from Earth to Luna: " + luna.DistanceToOrbiting() + " Km");
        }
    }
}