namespace StoreAPI.DTOs
{
    public record SignUpDto(string? userName, string? password,
            string? email, string? city, int? id_country, string? firstName, string? lastName,
            int? postalCode, int? telephone, string? address);
}
