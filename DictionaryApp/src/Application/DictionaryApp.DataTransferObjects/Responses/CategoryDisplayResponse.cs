﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.DataTransferObjects.Responses
{
    public class CategoryDisplayResponse
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
