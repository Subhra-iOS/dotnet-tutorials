namespace MediatRDemo.Models
{
    public record PersonModel
    {
        public Guid Identifier { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
    }
}