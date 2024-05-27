using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class SocketsBlockItem : StringListBlockItem
    {
        public SocketsBlockItem()
        {

        }

        public override string PrefixText => "Sockets";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "Sockets";
        public override string SummaryText
        {
            get
            {
                var summaryItemText = " " + Items.Aggregate(string.Empty, (current, i) => current + " " + i);
                return "Sockets " + summaryItemText.TrimStart(' ');
            }
        }

        
        public override Color SummaryBackgroundColor => Colors.LightGray;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Sockets;
                
    }
}
