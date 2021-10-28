using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class BaseEnergyShieldBlockItem : NumericFilterPredicateBlockItem
    {
        public BaseEnergyShieldBlockItem()
        {
        }

        public BaseEnergyShieldBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand) : base (predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "BaseEnergyShield";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "Base Energy Shield";
        public override string SummaryText => "Base Energy Shield " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.RoyalBlue;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.BaseEnergyShield;
        public override int Minimum => 0;
        public override int Maximum => 5555;
    }
}
