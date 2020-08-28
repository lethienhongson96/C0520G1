﻿using StaffManagment.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagment.Services
{
    public interface IStaffService
    {
        IEnumerable<Province> GetProvinces();
        IEnumerable<District> GetDistricts(int provinceId);
        IEnumerable<Ward> GetWards(int districtId, int provinceId);
    }
}
