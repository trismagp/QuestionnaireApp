using API.Extensions;

namespace API.Entities;

public enum QuestionType
{
    MultipleChoice,
    FreeText,
    NumberInput,
    Selector,
    MultipleFreeText // New type for multiple free-text fields
}