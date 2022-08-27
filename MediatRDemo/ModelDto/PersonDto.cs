namespace MediatRDemo.ModelDto
{
    public record PersonDto
    {
        public Guid Identifier { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
    }
}