﻿using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class IdentifiedBlockItem : BooleanBlockItem
    {
        public IdentifiedBlockItem()
        {
        }

        public IdentifiedBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "Identified";
        public override string DisplayHeading => "Identified";
        public override Color SummaryBackgroundColor => Colors.Wheat;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Identified;
    }
}
