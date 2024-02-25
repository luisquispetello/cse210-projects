public class StrengthExercise : Exercise
{
  private int _repetitions;
  private int _sets;
  private int _weightLiftedInKg;

  public StrengthExercise(string name, int repetitions, int sets, int weightLiftedInKg) : base(name)
  {
    _repetitions = repetitions;
    _sets = sets;
    _weightLiftedInKg = weightLiftedInKg;
  }

  public override double CalculateCaloriesBurned()
  {


    return _repetitions * _sets * _weightLiftedInKg * 0.001;
  }

  public override void DisplayExerciseDetails()
  {
    Console.WriteLine("Name: " + _name);
    Console.WriteLine("Type: Strength");
    Console.WriteLine("Repetitions: " + _repetitions);
    Console.WriteLine("Sets: " + _sets);
    Console.WriteLine("Weight Lifted: " + _weightLiftedInKg + " kg");
  }
}
