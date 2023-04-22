
namespace Algorithms.Easy.Fish
{
    public class FishFightValidation : IFishFightValidation
    {
        public Range NumberOfFishRange { get; set; }

        public Range SizesElementsRange { get; set; }

        public Range DirectionsElementsRange { get; set; }

        public bool IsValid { get; set; }


        public FishFightValidation(int[] sizes, int[] directions)
        {
            NumberOfFishRange = new Range(0, 100000);
            SizesElementsRange = new Range(0 , 1000000000); 
            DirectionsElementsRange = new Range(0, 1); 
            IsValid = ValidateFishFightInputs(sizes, directions);
        }

        public bool ValidateFishFightInputs(int[] sizes, int[] directions) =>
            HaveSameLength(sizes, directions) &&
            ElementsAreAllDiferents(sizes) &&
            ElementsAreBetweenRange(sizes, SizesElementsRange) &&
            ElementsAreBetweenRange(directions, DirectionsElementsRange) &&
            NumberOfFishInTheRiverIsValid(sizes, NumberOfFishRange);

        private bool HaveSameLength(int[] sizes, int[] directions) =>
            sizes.Length == directions.Length;

        private bool ElementsAreAllDiferents(int[] sizes) =>
            sizes.Distinct().Count() == sizes.Length;

        private bool ElementsAreBetweenRange(int[] array, Range range) =>
            array.Min() >= range.Start.Value && array.Max() <= range.End.Value;

        private bool NumberOfFishInTheRiverIsValid(int[] sizes, Range sizesRange) =>
            sizes.Length >= sizesRange.Start.Value && sizes.Length < sizesRange.End.Value;
    }
}
