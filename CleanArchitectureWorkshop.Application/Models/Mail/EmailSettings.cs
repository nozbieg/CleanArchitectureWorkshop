﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Models.Mail
{
    public class EmailSettings
    {
        public string ApiKey { get; set; }
        public string FromAdress { get; set; }
        public string FromName { get; set; }
    }
}