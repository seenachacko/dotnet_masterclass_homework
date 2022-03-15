namespace webApplicationHw.Models;

public class ConversionResponse
{
    public double Value { get; set; }
    public string ValueType { get; set; }
    public List<ConversionResponse> conversions(ConversionRequest Request)
    {
        List<ConversionResponse> Response = new List<ConversionResponse>();
        if (Request.TypeToConvert == ConversionRequest.ValueType.Gallons)
        {
            var firstType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Gallons).ToString();
            var secondType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Liters).ToString();
            Response.Add(new ConversionResponse { Value = Request.Value, ValueType = firstType });
            Response.Add(new ConversionResponse { Value = Request.Value * 3.785, ValueType = secondType });
        }
        else if (Request.TypeToConvert == ConversionRequest.ValueType.Miles)
        {
            var firstType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Miles).ToString();
            var secondType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Kilometeres).ToString();
            Response.Add(new ConversionResponse { Value = Request.Value, ValueType = firstType });
            Response.Add(new ConversionResponse { Value = Request.Value * 1.609, ValueType = secondType });
        }
        else if (Request.TypeToConvert == ConversionRequest.ValueType.Pounds)
        {
            var firstType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Pounds).ToString();
            var secondType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Kilograms).ToString();
            Response.Add(new ConversionResponse { Value = Request.Value, ValueType = firstType });
            Response.Add(new ConversionResponse { Value = Request.Value * 0.453, ValueType = secondType });
        }
        else if (Request.TypeToConvert == ConversionRequest.ValueType.Yards)
        {
            var firstType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Yards).ToString();
            var secondType = ((ConversionRequest.ValueType)ConversionRequest.ValueType.Meters).ToString();
            Response.Add(new ConversionResponse { Value = Request.Value, ValueType = firstType });
            Response.Add(new ConversionResponse { Value = Request.Value * 0.914, ValueType = secondType });
            return Response;
        }
        return Response;
    }

}