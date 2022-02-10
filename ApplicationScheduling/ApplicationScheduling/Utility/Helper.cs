using Microsoft.AspNetCore.Mvc.Rendering;
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

        public static string appointmentAdded = "Appointment added successfully.";
        public static string appointmentUpdated = "Appointment updated successfully.";
        public static string appointmentDeleted = "Appointment delete successfully.";
        public static string appointmentExisted = "Appointment for selected date time already exists";
        public static string appointmentNoExists = "Appointment not exists";
        public static string meetingConfirm = "meeting successfully confirmed.";
        public static string meetingConfirmError = "Error while confirming meeting";


        public static string appointmentAddError = "Something went wrong, Please try again.";
        public static string appointmentUpdateError = "Something went wrong, please try again.";
        public static string somethingWentWorng = "Something went wrong, please try again.";
        public static int success_code = 1;
        public static int failure_code = 0;



        public static List<SelectListItem> GetRsolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Helper.Admin,Text=Helper.Admin},
                new SelectListItem{Value=Helper.Doctor,Text=Helper.Doctor},
                new SelectListItem{Value=Helper.Patient,Text=Helper.Patient}
            };
        }

        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 60;
            List<SelectListItem> duration = new List<SelectListItem>();
            for(int i = 1; i < 12; i++ )
            {
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + "Hr" });
                minute = minute + 30;
                duration.Add(new SelectListItem { Value = minute.ToString(), Text = i + "Hr 30min" });
                minute = minute + 30;
            }

            return duration;
        }
    }
}
