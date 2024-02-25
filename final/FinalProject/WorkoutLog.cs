
public class WorkoutLog
{
  private List<WorkoutPlan> _completedWorkouts;
  private int _record;

  public WorkoutLog()
  {
    _completedWorkouts = new List<WorkoutPlan>();
    _record = 0;
  }

  public void AddCompletedWorkout(WorkoutPlan completedWorkout)
  {
    _completedWorkouts.Add(completedWorkout);
    _record++;
  }

  public List<WorkoutPlan> GetCompletedWorkouts()
  {
    return _completedWorkouts;
  }

  public void DisplayWorkoutLog()
  {
    foreach (WorkoutPlan workoutPlan in _completedWorkouts)
    {
      Console.WriteLine($"Workout name: {workoutPlan.GetName()}");
      Console.WriteLine($"Days completed: {_record}/{workoutPlan.GetDuration()}");
    }
  }
}
