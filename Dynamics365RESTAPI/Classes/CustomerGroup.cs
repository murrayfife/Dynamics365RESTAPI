using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamics365RESTAPI.Classes
{
    class CustomerGroup
    {
        public string dataAreaId { get; set; }
        public string CustomerGroupId { get; set; }
        public string Description { get; set; }
        public string ClearingPeriodPaymentTermName { get; set; }
        public string CustomerAccountNumberSequence { get; set; }
        public string DefaultDimensionDisplayValue { get; set; }
        public string IsSalesTaxIncludedInPrice { get; set; }
        public string WriteOffReason { get; set; }
        public string PaymentTermId { get; set; }
        public string TaxGroupId { get; set; }

    }
}
