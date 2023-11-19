using System;
using System.Collections.Generic;

namespace CostsCalculator.Data;

public partial class USERS_DEV
{
    public decimal USER_ID { get; set; }

    public string USER_NAME { get; set; } = null!;

    public string? USER_EMAIL { get; set; }

    public string USER_PASSWORD { get; set; } = null!;
}
