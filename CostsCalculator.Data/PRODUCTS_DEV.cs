using System;
using System.Collections.Generic;

namespace CostsCalculator.Data;

public partial class PRODUCTS_DEV
{
    public decimal PRODUCT_ID { get; set; }

    public decimal? PRODUCT_USER_ID { get; set; }

    public string PRODUCT_NAME { get; set; } = null!;

    public virtual USERS? PRODUCT_USER { get; set; }
}
