using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics365RESTAPI.Classes
{
    class Product
    {
        public string dataAreaId { get; set; }
        public string ItemNumber { get; set; }
        public string BOMUnitSymbol { get; set; }
        public string TrackingDimensionGroupName { get; set; }
        public double UnitCostQuantity { get; set; }
        public double TareProductWeight { get; set; }
        public double ShelfLifePeriodDays { get; set; }
        public double NetProductWeight { get; set; }
        public string PrimaryVendorAccountNumber { get; set; }
        public string ProductLifeCycleSeasonCode { get; set; }
        public string ProductionGroupId { get; set; }
        public string SearchName { get; set; }
        public string StorageDimensionGroupName { get; set; }
        public string PurchaseUnitSymbol { get; set; }
        public string ValueABCCode { get; set; }
        public string SalesUnitSymbol { get; set; }
        public double GrossDepth { get; set; }
        public double GrossProductHeight { get; set; }
        public double GrossProductWidth { get; set; }
        public string CostGroupId { get; set; }
        public double UnitCost { get; set; }
        public string ProductType { get; set; }
        public string BuyerGroupId { get; set; }
        public string ProductGroupId { get; set; }
        public double BestBeforePeriodDays { get; set; }
        public double PurchasePrice { get; set; }
        public double SalesPrice { get; set; }
        public string ProductNumber { get; set; }
        public double ProductVolume { get; set; }
        public string ItemModelGroupId { get; set; }
        public string DefaultOrderType { get; set; }
        public string InventoryUnitSymbol { get; set; }

    }
}
