public class CardioExercise : Exercise
{
  private int _durationInMinutes;

  // Constructor
  public CardioExercise(string name, int difficultyLevel, int duration)
    : base(name, difficultyLevel)
  {
    _durationInMinutes = duration;
  }

  public override double CalculateCaloriesBurned()
  {
    return 0;
  }
}