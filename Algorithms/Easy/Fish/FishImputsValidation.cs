namespace Algorithms.Easy.Fish
{
	public class FishImputsValidation
	{
		readonly bool result = true;

		public bool ValidateImputs(int[] arrayA, int[] arrayB)
		{
			return ArraysHaveSameLenght(arrayA, arrayB) &&
				   NumberOfFishInTheRiverIsValid(arrayA, 0, 100000) &&
				   ArrayElementsAreAllIntegerBetweenRange(arrayA, 0, 1000000000) &&
				   ArrayElementsAreAllIntegerBetweenRange(arrayB, 0, 1) &&
				   ArrayElementsAreAllDiferents(arrayA);
		}

		public bool ArraysHaveSameLenght(int[] arrayA, int[] arrayB)
		{
			return arrayA.Length == arrayB.Length;
		}

		public bool NumberOfFishInTheRiverIsValid(int[] arrayA, int minValue, int maxValue)
		{
			return arrayA.Length > minValue && arrayA.Length < maxValue;
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

		public bool ArrayElementsAreAllDiferents(int[] arrayA)
		{
			for (int i = 0; i < arrayA.Length - 1; i++)
			{
				for (int j = i + 1; j < arrayA.Length; j++)
				{
					if (arrayA[i] == arrayA[j])
					{
						return false;
					}
				}
			}

			return result;
		}
	}
}
