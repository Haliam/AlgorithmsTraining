namespace Algorithms.Easy.Fish
{
	public class FishInputsValidation
	{
		public bool ValidateInputs(int[] A, int[] B)
		{
			return ArraysHaveSameLenght(A, B) &&
				   NumberOfFishInTheRiverIsValid(A, 0, 100000) &&
				   ElementsBetweenRange(A, 0, 1000000000) &&
				   ElementsBetweenRange(B, 0, 1) &&
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

		public bool ElementsBetweenRange(int[] array, int minValue, int maxValue)
		{
			foreach (var element in array)
			{
				if (element < minValue || element > maxValue)
				{
					return false;
				}
			}

			return true;
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

			return true;
		}
	}
}
