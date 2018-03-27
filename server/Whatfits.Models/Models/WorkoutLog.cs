﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Whatfits.Models.Interfaces;

namespace Whatfits.Models.Models
{
    /// <summary>
    /// Represents a workoutlog that tracks one workout either cardio or 
    /// weightlifting.
    /// </summary>
    public class WorkoutLog : IWorkoutLog
    {
        // Primary Key
        [Key, Column(Order = 0)]
        public int WorkoutLogID { get; set; }

        // Foreign Key - Maps to the Security Table
        [Key, Column(Order = 1)]
        public int UserID { get; set; }

        // Stores the workoutype
        public string WorkoutType { get; set; }

        // Stores the date and time it was created
        public DateTime Date_Time { get; set; }

        // Workout log can have many Weightlifting Logs and Cardio Logs
        public ICollection<WeightLifting> WeightLifting { get; set; }
        public ICollection<Cardio> Cardio { get; set; }
    }
}