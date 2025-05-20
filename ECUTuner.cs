using System;
using System.IO;
using System.Threading;

namespace ECUTuner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ECU Tuner v1.0");
            Console.WriteLine("------------------");
            
            bool exitProgram = false;
            
            while (!exitProgram)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. ECU Status");
                Console.WriteLine("2. Mild Tune");
                Console.WriteLine("3. Moderate Tune");
                Console.WriteLine("4. FULL SEND");
                Console.WriteLine("5. Exit");
                
                Console.Write("\nSelect an option: ");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        ShowECUStatus();
                        break;
                    case "2":
                        ApplyTune("Mild", 10);
                        break;
                    case "3":
                        ApplyTune("Moderate", 25);
                        break;
                    case "4":
                        FullSend();
                        break;
                    case "5":
                        exitProgram = true;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
        
        static void ShowECUStatus()
        {
            Console.WriteLine("\n--- ECU Status ---");
            Console.WriteLine("Connection: Simulated");
            Console.WriteLine("Current Mode: Stock");
            Console.WriteLine("Engine Temperature: 90°C");
            Console.WriteLine("Boost Pressure: 14.7 PSI");
            Console.WriteLine("Timing Advance: Stock");
            Console.WriteLine("Fuel Mixture: Stock");
            Console.WriteLine("-----------------");
        }
        
        static void ApplyTune(string tuneLevel, int percentage)
        {
            Console.WriteLine($"\nApplying {tuneLevel} tune...");
            
            // Simulate progress
            for (int i = 0; i <= 100; i += 5)
            {
                Console.Write($"\rProgress: {i}% ");
                Thread.Sleep(100);
            }
            
            Console.WriteLine("\nTune applied successfully!");
            Console.WriteLine($"Performance increase: ~{percentage}%");
            Console.WriteLine("Remember to monitor engine parameters after tuning.");
        }
        
        static void FullSend()
        {
            Console.WriteLine("\n*** INITIATING FULL SEND MODE ***");
            Console.WriteLine("WARNING: This mode removes all performance limiters!");
            Console.WriteLine("Proceed with caution!");
            
            Console.Write("\nAre you sure you want to proceed? (y/n): ");
            string confirmation = Console.ReadLine().ToLower();
            
            if (confirmation == "y" || confirmation == "yes")
            {
                Console.WriteLine("\nInitiating FULL SEND sequence...");
                
                string[] steps = {
                    "Disabling rev limiter",
                    "Maximizing boost pressure",
                    "Optimizing fuel delivery",
                    "Adjusting timing for maximum power",
                    "Disabling traction control",
                    "Optimizing torque curve",
                    "Finalizing FULL SEND mode"
                };
                
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.Write($"{steps[i]}...");
                    Thread.Sleep(800);
                    Console.WriteLine(" DONE");
                }
                
                Console.WriteLine("\n*** FULL SEND MODE ACTIVATED ***");
                Console.WriteLine("Maximum performance settings applied!");
                Console.WriteLine("WARNING: Use at your own risk. Monitor engine closely.");
            }
            else
            {
                Console.WriteLine("FULL SEND mode aborted. Returning to stock settings.");
            }
        }
    }
}
