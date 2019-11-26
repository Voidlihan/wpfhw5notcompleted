using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_HW5
{
    public abstract class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
