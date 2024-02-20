public class StrengthExercise : Exercise
{
  private double _weightLiftedInKg;

  // Constructor
  public StrengthExercise(string name, int difficultyLevel, double weightLifted)
    : base(name, difficultyLevel)
  {
    _weightLiftedInKg = weightLifted;
  }

  public override double CalculateCaloriesBurned()
  {
    return 0;
  }
}
