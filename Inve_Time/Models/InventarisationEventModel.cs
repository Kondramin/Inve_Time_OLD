﻿using Inve_Time.Models.Base;
using System;
using System.Collections.ObjectModel;

namespace Inve_Time.Models
{
    public class InventoryEventModel : EntityModel
    {
        public DateTime DateOfEvent { get; set; }
        public bool OpenToModifi { get; set; } = true;



        public EmployeeModel ResponsibleEmployee { get; set; }



        public MarketModel Market { get; set; }



        public ObservableCollection<ProductInventedModel> ProductInventeds { get; set; }

    }
}
