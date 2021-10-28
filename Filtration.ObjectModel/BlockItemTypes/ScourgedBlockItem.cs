using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class ScourgedBlockItem : BooleanBlockItem
    {
        public ScourgedBlockItem()
        {
        }

        public ScourgedBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "Scourged";
        public override string DisplayHeading => "Scourged";
        public override Color SummaryBackgroundColor => Colors.DarkOrange;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Scourged;
    }
}
