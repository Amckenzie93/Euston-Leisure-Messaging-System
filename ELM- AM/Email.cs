﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ELM__AM
{
    public class Email
    {
        public string ID { get; set; }
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string EmailMessage { get; set; }
        public string BranchCode { get; set; }
        public string IncidentCode { get; set; }

        public Email()
        {

        }

    }

    public class SIR
    {
        public string BranchCode { get; set; }
        public string IncidentCode { get; set; }

        public SIR()
        {

        }
    }


}