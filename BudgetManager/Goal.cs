//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goal
    {
        public int GoalID { get; set; }
        public int BudgetID { get; set; }
        public int Category { get; set; }
        public double Amount { get; set; }
    
        public virtual Budget Budget { get; set; }
    }
}
