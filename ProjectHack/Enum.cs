﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHack
{
    
    public enum StatusUrgence { veryUrgent, Urgent, NotUrgent };
    public enum statusOfReport { Waiting, handled };
    public enum CategoryNameEnum
    {
        Road_Problem, Urban_Problem, Other
    };
    public enum SubCategoryNameRoadEnum
    {
        Accident, Disruptive_object, Disruptive_parking, Defective_indication, Other
    };

    public enum SubCategoryNameUrbanEnum
    {
        Neighborhood_problem,Pollution, Animals, Distruptive_object, Tag, Other
    };
}
