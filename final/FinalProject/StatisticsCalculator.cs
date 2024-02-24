public class StatisticsCalculator
{
  public double CalculateAverageDuration(List<WorkoutPlan> workoutLogs)
  {
    if (workoutLogs.Count == 0)
      return 0;

    double totalDuration = 0;
    foreach (WorkoutPlan workout in workoutLogs)
    {
      totalDuration += workout.GetTotalDuration();
    }
    return totalDuration / workoutLogs.Count;
  }

  public double CalculateTotalCaloriesBurned(List<WorkoutPlan> workoutLogs)
  {
    double totalCalories = 0;
    foreach (WorkoutPlan workout in workoutLogs)
    {
      totalCalories += workout.GetTotalCalories();
    }
    return totalCalories;
  }
}
