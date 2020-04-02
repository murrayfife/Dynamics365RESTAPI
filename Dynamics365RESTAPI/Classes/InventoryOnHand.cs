using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics365RESTAPI.Classes
{
    class InventoryOnHand
    {
        public string dataAreaId { get; set; }
        public string ItemNumber { get; set; }
        public string ProductColorId { get; set; }
        public string ProductConfigurationId { get; set; }
        public string ProductSizeId { get; set; }
        public string ProductStyleId { get; set; }
        public string InventorySiteId { get; set; }
        public double AvailableOrderedQuantity { get; set; }
        public double OnHandQuantity { get; set; }
        public double AvailableOnHandQuantity { get; set; }
        public double OnOrderQuantity { get; set; }
        public double TotalAvailableQuantity { get; set; }
        public double OrderedQuantity { get; set; }
        public string AreWarehouseManagementProcessesUsed { get; set; }
        public double ReservedOrderedQuantity { get; set; }
        public string ProductName { get; set; }
        public double ReservedOnHandQuantity { get; set; }
    }
}
