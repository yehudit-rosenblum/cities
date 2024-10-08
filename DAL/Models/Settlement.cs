using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Settlement
{
    public int Id { get; set; }

    public string SettlementName { get; set; } = null!;
}
