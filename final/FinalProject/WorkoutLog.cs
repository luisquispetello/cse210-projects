public class WorkoutLog
{
  private List<WorkoutPlan> _completedWorkouts;

  public WorkoutLog()
  {
    _completedWorkouts = new List<WorkoutPlan>();
  }

  public void AddCompletedWorkout(WorkoutPlan workout)
  {
    _completedWorkouts.Add(workout);
  }

  public List<WorkoutPlan> GetCompletedWorkouts()
  {
    return _completedWorkouts;
  }
}
