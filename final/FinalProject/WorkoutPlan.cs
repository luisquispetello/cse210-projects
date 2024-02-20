public class WorkoutPlan
{

  public DateTime _date;
  public List<Exercise> _exercises = new();

  public void AddExercise(Exercise exercise)
  {
    _exercises.Add(exercise);
  }

  public void RemoveExercise(Exercise exercise)
  {
    _exercises.Remove(exercise);
  }
}
