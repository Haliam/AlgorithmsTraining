namespace Algorithms.Easy.Fish
{
	public class FishImputsValidation
	{
		readonly bool result = true;

		public bool ValidateImputs(int[] A, int[] B)
		{
			return ArraysHaveSameLenght(A, B) &&
				   NumberOfFishInTheRiverIsValid(A, 0, 100000) &&
				   ArrayElementsAreAllIntegerBetweenRange(A, 0, 1000000000) &&
				   ArrayElementsAreAllIntegerBetweenRange(B, 0, 1) &&
				   ArrayElementsAreAllDiferents(A);
		}

		public bool ArraysHaveSameLenght(int[] A, int[] B)
		{
			return A.Length == B.Length;
		}

		public bool NumberOfFishInTheRiverIsValid(int[] A, int minValue, int maxValue)
		{
			return A.Length > minValue && A.Length < maxValue;
		}

		public bool ArrayElementsAreAllIntegerBetweenRange(int[] array, int minValue, int maxValue)
		{
			foreach (var element in array)
			{
				if (element < minValue || element > maxValue)
				{
					return false;
				}
			}

			return result;
		}

		public bool ArrayElementsAreAllDiferents(int[] A)
		{
			for (int i = 0; i < A.Length - 1; i++)
			{
				for (int j = i + 1; j < A.Length; j++)
				{
					if (A[i] == A[j])
					{
						return false;
					}
				}
			}

			return result;
		}
	}
}
