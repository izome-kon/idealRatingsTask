using System.Text.Json.Serialization;
using CsvHelper.Configuration.Attributes;

namespace TechnicalTaskIdealRatingsDotNet.DTOs;

public class PersonDto
{
    [JsonPropertyName("first name")]
    [Name("First Name")]
    public string FirstName { get; set; } = string.Empty;
    [JsonPropertyName("last name")]
    [Name("Last Name")]
    public string LastName { get; set; } = string.Empty;
    [JsonPropertyName("telephone code")]
    [Name("Country code")]
    public string TelephoneCode { get; set; } = string.Empty;
    [JsonPropertyName("telephone number")]
    [Name("Number")]
    public string TelephoneNumber { get; set; } = string.Empty;
    [JsonPropertyName("address")]
    [Name("Full Address")]
    public string Address { get; set; } = string.Empty;
    [JsonPropertyName("country")]
    [Name("Country")]
    public string Country { get; set; } = string.Empty;
}