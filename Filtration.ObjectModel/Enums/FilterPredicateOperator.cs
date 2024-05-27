using System.ComponentModel;

namespace Filtration.ObjectModel.Enums
{
    public enum FilterPredicateOperator
    {
        [Description("=")]
        Equal,
        [Description("!")]
        NotEqual,
        [Description("!=")]
        NotEqual2,
        [Description("<")]
        LessThan,
        [Description("<=")]
        LessThanOrEqual,
        [Description(">")]
        GreaterThan,
        [Description(">=")]
        GreaterThanOrEqual,
        [Description("==")]
        ExactEqual
    }
}
