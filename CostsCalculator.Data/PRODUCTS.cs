using System;
using System.Collections.Generic;

namespace CostsCalculator.Data;

public partial class PRODUCTS
{
    public decimal PRODUCT_ID { get; set; }

    public decimal? PRODUCT_USER_ID { get; set; }

    public string PRODUCT_NAME { get; set; } = null!;

    public virtual ICollection<ITEMS> ITEMS { get; set; } = new List<ITEMS>();

    public virtual ICollection<ITEMS_DEV> ITEMS_DEV { get; set; } = new List<ITEMS_DEV>();

    public virtual USERS? PRODUCT_USER { get; set; }
}
