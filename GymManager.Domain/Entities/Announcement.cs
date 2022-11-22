using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Domain.Entities;

public class Announcement
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
}
