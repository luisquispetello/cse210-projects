public abstract class Exercise
{
	private string _name;
	private int _difficultyLevel;

	public Exercise(string name, int difficultyLevel)
	{
		_name = name;
		_difficultyLevel = difficultyLevel;
	}

	public abstract double CalculateCaloriesBurned();
}
