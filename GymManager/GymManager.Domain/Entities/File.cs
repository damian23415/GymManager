using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Domain.Entities;

public class File
{
    public int Id { get; set; }
    public string Name { get; set; }
    public long Bytes { get; set; }
    public string Description { get; set; }
}
