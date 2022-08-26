



public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDatetime,
    List<string> Savory,
    List<string> Sweet
);

