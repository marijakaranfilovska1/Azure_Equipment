﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repository
{
    public interface IEquipmentRepository
    {
        List<Equipment> GetEquipment();
    }
}
