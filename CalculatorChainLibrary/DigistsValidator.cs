namespace CalculatorChainLibrary
{
    public class DigistsValidator : Validator
    {
        public override Response IsValid(Response value)
        {
            var response = value;
            var array = value.Input.Split(",");
            foreach ( var item in array )
            {
                if (int.TryParse(item, out int result))
                    response.Numbers.Add(result);
                else
                {
                    response.Error = "the string must contain only digits.";
                    response.Valid = false;
                    return response;
                }
            }
            return _successor.IsValid(response);
        }
    }
}