using System;
using System.Collections.Generic;

namespace OblakotekaTask.Domain.Entities;

public partial class EventLog
{
    public Guid Id { get; set; }

    public DateTime EventDate { get; set; }

    public string? Description { get; set; }
}
