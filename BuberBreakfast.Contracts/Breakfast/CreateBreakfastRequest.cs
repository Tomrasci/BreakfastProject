namespace BuberBreakfast.Contracts.BuberBreakfast

public record CreateBreakfastRequest(string Nmae, string Description, DateTime StartDateTime, DateTime EndDatetime, List<string> Savory, List<string> Sweet);