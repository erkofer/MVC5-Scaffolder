﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy.Scaffolding.MVC.Models
{
    public enum euColumnType
    {
        /// <summary>
        /// int
        /// </summary>
        intCT = 0x1
        ,
        /// <summary>
        /// decimal
        /// </summary>
        decimalCT = 0x3
        ,
        /// <summary>
        /// string
        /// </summary>
        stringCT = 0x0
        ,
        /// <summary>
        /// DateTime
        /// </summary>
        datetimeCT = 0x2
        ,
        /// <summary>
        /// RelatedModel
        /// </summary>
        RelatedModel = 0x4
    }
}