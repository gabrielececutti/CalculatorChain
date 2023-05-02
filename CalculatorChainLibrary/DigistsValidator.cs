namespace CalculatorChainLibrary
{
    public class DigistsValidator : Validator
    {
        public override Response IsValid(List<string> list)
        {
            if (int.TryParse(list[0], out int n1) && int.TryParse(list[1], out int n2))
            {
                if (_successor != null) return _successor.IsValid(list);
                return new Response { Error = string.Empty, Valid = true };
            }
            return new Response { Error = "the string must contain only numbers", Valid = false };
        }
    }
}