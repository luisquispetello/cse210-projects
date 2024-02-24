using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome to Fitness Tracker!");
		WorkoutManager workoutManager = new();
		workoutManager.Start();
	}
}