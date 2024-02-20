public class WorkoutLog
{
  public DateTime _date;
  public List<Exercise> _completedExercises = new();

  public void LogWorkout(List<Exercise> exercises)
  {
    _date = DateTime.Now;
    _completedExercises.AddRange(exercises);
  }
}
