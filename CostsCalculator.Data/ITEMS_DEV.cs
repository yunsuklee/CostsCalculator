using System;
using System.Collections.Generic;

namespace CostsCalculator.Data;

public partial class ITEMS_DEV
{
    public decimal ITEM_ID { get; set; }

    public decimal? ITEM_PRODUCT_ID { get; set; }

    public string ITEM_NAME { get; set; } = null!;

    public decimal? ITEM_BUY_QUANTITY { get; set; }

    public string? ITEM_BUY_UNIT { get; set; }

    public decimal? ITEM_BUY_PRICE { get; set; }

    public decimal? ITEM_USE_QUANTITY { get; set; }

    public string? ITEM_USE_UNIT { get; set; }

    public decimal? ITEM_USE_PRICE { get; set; }

    public virtual PRODUCTS? ITEM_PRODUCT { get; set; }
}
