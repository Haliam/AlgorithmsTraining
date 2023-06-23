namespace Algorithms.Easy.ClosestToZero
{
    public class ClosestToZero
    {
        public static int ComputeClosestToZero(int[] ts)
        {
            if (!ClosestToZeroValidation.IsValid(ts))
                return 0;

            int temperature = GetClosestToZeroTemperature(ts);

            return temperature;
        }

        private static int GetClosestToZeroTemperature(int[] ts)
        {
            int closestNegativeToZero = ts[0];
            int closestPositiveToZero = ts[0];
            int closestToZeroTemperature = 0;

            foreach (int t in ts)
            {
                if (t < 0)
                {
                    closestNegativeToZero = t < closestNegativeToZero ? t : closestNegativeToZero;
                }
                else
                {
                    closestPositiveToZero = t < closestPositiveToZero ? t : closestPositiveToZero;
                }
            }

            if (closestPositiveToZero == Math.Abs(closestNegativeToZero))
                return closestPositiveToZero;

            closestToZeroTemperature = closestPositiveToZero < Math.Abs(closestNegativeToZero) ? closestPositiveToZero : closestNegativeToZero;

            return closestToZeroTemperature;
        }       
    }
}
