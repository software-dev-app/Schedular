﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationScheduling.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Doctor = "Doctor";
        public static string Patient = "Patient";

        public static List<SelectListItem> GetRsolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Admin,Text=Helper.Admin},
                new SelectListItem{Value=Helper.Doctor,Text=Helper.Doctor},
                new SelectListItem{Value=Helper.Patient,Text=Helper.Patient}
            };
        }
    }
}