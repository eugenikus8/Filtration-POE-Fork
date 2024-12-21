﻿using System.Linq;
using Filtration.ObjectModel;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.BlockItemTypes;

namespace Filtration.ItemFilterPreview.Services
{
    internal interface IBlockItemMatcher
    {
        bool ItemBlockMatch(IItemFilterBlock block, IItem item);
        bool ItemBlockItemMatch(IItemFilterBlockItem blockItem, IItem item);
    }

    internal class BlockItemMatcher : IBlockItemMatcher
    {
        public bool ItemBlockMatch(IItemFilterBlock block, IItem item)
        {

            var match =  block.BlockItems
                .Where(blockItem => !(blockItem is IAudioVisualBlockItem) && !(blockItem is ActionBlockItem))
                .All(blockItem => ItemBlockItemMatch(blockItem, item));

            return match;
        }

        public bool ItemBlockItemMatch(IItemFilterBlockItem blockItem, IItem item)
        {
            var blockItemType = blockItem.GetType();

            if (blockItemType == typeof (BaseTypeBlockItem))
                return BaseTypeBlockItemMatch((BaseTypeBlockItem)blockItem, item);

            if (blockItemType == typeof (ClassBlockItem))
                return ClassBlockItemMatch((ClassBlockItem) blockItem, item);

            if (blockItemType == typeof(DropLevelBlockItem))
                return DropLevelBlockItemMatch((DropLevelBlockItem)blockItem, item);

            if (blockItemType == typeof(HeightBlockItem))
                return HeightBlockItemMatch((HeightBlockItem)blockItem, item);

            if (blockItemType == typeof(ItemLevelBlockItem))
                return ItemLevelBlockItemMatch((ItemLevelBlockItem)blockItem, item);

            if (blockItemType == typeof(AreaLevelBlockItem))
                return AreaLevelBlockItemMatch((AreaLevelBlockItem)blockItem, item);

            if (blockItemType == typeof(LinkedSocketsBlockItem))
                return LinkedSocketsBlockItemMatch((LinkedSocketsBlockItem)blockItem, item);

            if (blockItemType == typeof(SocketsBlockItem))
                return SocketsBlockItemMatch((SocketsBlockItem)blockItem, item);

            if (blockItemType == typeof(QualityBlockItem))
                return QualityBlockItemMatch((QualityBlockItem)blockItem, item);

            if (blockItemType == typeof(BaseArmourBlockItem))
                return BaseArmourBlockItemMatch((BaseArmourBlockItem)blockItem, item);

            if (blockItemType == typeof(BaseDefencePercentileBlockItem))
                return BaseDefencePercentileBlockItemMatch((BaseDefencePercentileBlockItem)blockItem, item);

            if (blockItemType == typeof(BaseEnergyShieldBlockItem))
                return BaseEnergyShieldBlockItemMatch((BaseEnergyShieldBlockItem)blockItem, item);

            if (blockItemType == typeof(BaseEvasionBlockItem))
                return BaseEvasionBlockItemMatch((BaseEvasionBlockItem)blockItem, item);

            if (blockItemType == typeof(BaseWardBlockItem))
                return BaseWardBlockItemMatch((BaseWardBlockItem)blockItem, item);

            if (blockItemType == typeof(EnchantmentPassiveNumBlockItem))
                return EnchantmentPassiveNumBlockItemMatch((EnchantmentPassiveNumBlockItem)blockItem, item);

            if (blockItemType == typeof(RarityBlockItem))
                return RarityBlockItemMatch((RarityBlockItem)blockItem, item);




            if (blockItemType == typeof(WidthBlockItem))
                return WidthBlockItemMatch((WidthBlockItem)blockItem, item);

            if (blockItemType == typeof(SocketGroupBlockItem))
                return SocketGroupBlockItemMatch((SocketGroupBlockItem)blockItem, item);
                        
            return false;
        }

        private static bool BaseTypeBlockItemMatch(BaseTypeBlockItem baseTypeBlockItem, IItem item)
        {
            return baseTypeBlockItem.Items.Any(b => item.BaseType.StartsWith(b));
        }

        private static bool ClassBlockItemMatch(ClassBlockItem classBlockItem, IItem item)
        {
            return classBlockItem.Items.Any(c => item.ItemClass.Contains(c));
        }

        private static bool DropLevelBlockItemMatch(DropLevelBlockItem dropLevelBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(dropLevelBlockItem, item.DropLevel);
        }

        private static bool HeightBlockItemMatch(HeightBlockItem heightBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(heightBlockItem, item.Height);
        }

        private static bool ItemLevelBlockItemMatch(ItemLevelBlockItem itemLevelBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(itemLevelBlockItem, item.ItemLevel);
        }
        private static bool AreaLevelBlockItemMatch(AreaLevelBlockItem areaLevelBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(areaLevelBlockItem, item.AreaLevel);
        }

        private static bool LinkedSocketsBlockItemMatch(LinkedSocketsBlockItem linkedSocketsBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(linkedSocketsBlockItem, item.LinkedSockets);
        }

        private static bool SocketsBlockItemMatch(SocketsBlockItem socketsBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(socketsBlockItem, item.SocketCount);
        }

        private static bool QualityBlockItemMatch(QualityBlockItem qualityBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(qualityBlockItem, item.Quality);
        }

        private static bool BaseDefencePercentileBlockItemMatch(BaseDefencePercentileBlockItem BaseDefencePercentileBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(BaseDefencePercentileBlockItem, item.BaseDefencePercentile);
        }

        private static bool BaseArmourBlockItemMatch(BaseArmourBlockItem BaseArmourBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(BaseArmourBlockItem, item.BaseArmour);
        }

        private static bool BaseEnergyShieldBlockItemMatch(BaseEnergyShieldBlockItem BaseEnergyShieldBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(BaseEnergyShieldBlockItem, item.BaseEnergyShield);
        }

        private static bool BaseEvasionBlockItemMatch(BaseEvasionBlockItem BaseEvasionBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(BaseEvasionBlockItem, item.BaseEvasion);
        }

        private static bool BaseWardBlockItemMatch(BaseWardBlockItem BaseWardBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(BaseWardBlockItem, item.BaseWard);
        }

        private static bool EnchantmentPassiveNumBlockItemMatch(EnchantmentPassiveNumBlockItem EnchantmentPassiveNumBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(EnchantmentPassiveNumBlockItem, item.EnchantmentPassiveNum);
        }


        private static bool RarityBlockItemMatch(RarityBlockItem qualityBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(qualityBlockItem, (int)item.ItemRarity);
        }

        private static bool GemQualityTypeBlockItemMatch(GemQualityTypeBlockItem qualityBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(qualityBlockItem, (int)item.GemQualityType);
        }



        private static bool WidthBlockItemMatch(WidthBlockItem widthBlockItem, IItem item)
        {
            return NumericFilterPredicateBlockItemMatch(widthBlockItem, item.Width);
        }


        private static bool SocketGroupBlockItemMatch(SocketGroupBlockItem socketGroupBlockItem, IItem item)
        {

            foreach (var blockItemSocketGroup in socketGroupBlockItem.SocketGroups) // for each group of sockets in the block item
            {
                foreach (var itemLinkedSocketGroup in item.LinkedSocketGroups) // for each linked socket group in the item
                {
                    if (SocketGroupHasRequiredSocketColors(itemLinkedSocketGroup, blockItemSocketGroup))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool SocketGroupHasRequiredSocketColors(SocketGroup itemLinkedSocketGroup, SocketGroup blockItemSocketGroup)
        {

            var blockSocketGroupColorCounts = blockItemSocketGroup.GroupBy(i => i.Color, (key, values) => new { SocketColor = key, Count = values.Count() }).ToList();
            var itemSocketGroupColorCounts = itemLinkedSocketGroup.GroupBy(i => i.Color, (key, values) => new {SocketColor = key, Count = values.Count()}).ToList();

            foreach (var blockItemSocketColorCount in blockSocketGroupColorCounts)
            {
                var match = itemSocketGroupColorCounts.FirstOrDefault(i => i.SocketColor == blockItemSocketColorCount.SocketColor && i.Count >= blockItemSocketColorCount.Count);
                if (match == null)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool NumericFilterPredicateBlockItemMatch<T>(T numericFilterPredicateBlockItem, int matchValue) where T : NumericFilterPredicateBlockItem
        {
            return numericFilterPredicateBlockItem.FilterPredicate.CompareUsing(matchValue);
        }
    }
}
