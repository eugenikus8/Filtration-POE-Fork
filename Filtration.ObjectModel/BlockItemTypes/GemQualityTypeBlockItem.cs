using System.Linq;
using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class GemQualityTypeBlockItem : StringListBlockItem
    {
        public override string PrefixText => "GemQualityType";
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "Gem Quality Type";

        public override string SummaryText
        {
            get
            {
                if (Items.Count > 0 && Items.Count < 4)
                {
                    return "GemQualityType: " +
                           Items.Aggregate(string.Empty, (current, i) => current + i + ", ").TrimEnd(' ').TrimEnd(',');
                }
                if (Items.Count >= 4)
                {
                    var remaining = Items.Count - 3;
                    return "GemQualityType: " + Items.Take(3)
                        .Aggregate(string.Empty, (current, i) => current + i + ", ")
                        .TrimEnd(' ')
                        .TrimEnd(',') + " (+" + remaining + " more)";
                }
                return "GemQualityType: (none)";
            }
        }

        public override Color SummaryBackgroundColor => Colors.PaleGreen;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.GemQualityType;
    }
}
