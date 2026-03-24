using System;

using System.Collections.Generic;

using ContainersApp.Containers;

using ContainersApp.Core;

using ContainersApp.Shipping;

namespace ContainersApp;

/// <summary>

/// Demo entry point that exercises the core features without any UI.

/// </summary>

internal class Program

{

    private static void Main(string[] args)

    {

        try

        {

            var ship1 = new Ship("Kanopus", 25, 5, 100);

            var ship2 = new Ship("Capella", 22, 5, 150);

            var liquid = new LiquidContainer(250, 800, 400, 5000, isHazardous: true);

            liquid.LoadCargo(2000);

            var gas = new GasContainer(260, 900, 450, 4500, pressureAtm: 2.0);

            gas.LoadCargo(4000);

            var fridge = new RefrigeratedContainer(270, 950, 470, 3000, "Meat", -15);

            fridge.LoadCargo(1500);

            ship1.LoadContainerList(new List<Container> { liquid, gas, fridge });

            Console.WriteLine("\n=== Ship Kanopus ===");

            ship1.PrintInfo();

            Console.WriteLine("\nTransferring gas container to Capella…");

            ship1.TransferContainerTo(gas.SerialNumber, ship2);

            Console.WriteLine("\n=== Kanopus after transfer ===");

            ship1.PrintInfo();

            Console.WriteLine("\n=== Capella after transfer ===");

            ship2.PrintInfo();

            Console.WriteLine("\nUnloading refrigerated container on Kanopus…");

            ship1.UnloadContainer(fridge.SerialNumber);

            ship1.PrintContainerInfo(fridge.SerialNumber);

            Console.WriteLine("\nDemo completed successfully.");

        }

        catch (Exception ex)

        {

            Console.WriteLine($"ERROR: {ex.Message}");

        }

    }

}