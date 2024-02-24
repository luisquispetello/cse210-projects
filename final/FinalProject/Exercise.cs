public abstract class Exercise
{
	protected string _name;

	public Exercise(string name)
	{
		_name = name;
	}

	public abstract double CalculateCaloriesBurned();
	public abstract void DisplayExerciseDetails();
}
