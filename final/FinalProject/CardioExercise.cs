public class CardioExercise : Exercise
{
  private int _durationInMinutes;

  public CardioExercise(string name, int durationInMinutes) : base(name)
  {
    _durationInMinutes = durationInMinutes;
  }
  
  public int DurationInMinutes
  {
    get { return _durationInMinutes; }
    set { _durationInMinutes = value; }
  }

  public override double CalculateCaloriesBurned()
  {
    // double kcalPerMinute = met * 0.0175 * user.GetWeight();
    // return kcalPerMinute * _durationInMinutes;


    return _durationInMinutes * 10;
  }

  public override void DisplayExerciseDetails()
  {
    Console.WriteLine("Exercise Details:");
    Console.WriteLine("Name: " + _name);
    Console.WriteLine("Type: Cardio");
    Console.WriteLine("Duration: " + _durationInMinutes + " minutes");
  }
}