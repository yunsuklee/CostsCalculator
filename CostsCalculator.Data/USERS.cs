using System;
using System.Collections.Generic;

namespace CostsCalculator.Data;

public partial class USERS
{
    public decimal USER_ID { get; set; }

    public string USER_NAME { get; set; } = null!;

    public string? USER_EMAIL { get; set; }

    public string USER_PASSWORD { get; set; } = null!;

    public virtual ICollection<PRODUCTS> PRODUCTS { get; set; } = new List<PRODUCTS>();

    public virtual ICollection<PRODUCTS_DEV> PRODUCTS_DEV { get; set; } = new List<PRODUCTS_DEV>();
}
