﻿using System;
using System.Text.RegularExpressions;

namespace ELM__AM
{
    public class Email
    {
        private string _id;
        private string _emailAddress;
        private string _subject;
        private string _emailMessage;
        private string _branchCode;
        private string _incidentCode;

        //Email constructor for manual input of data into header and body fileds.
        public Email(string id, string messageBody, DataCollection data)
        {
            ID = id;
            var body = messageBody.Split(',');
            if (body.Length == 3)
            {
                Subject = body[0];
                EmailAddress = body[1];
                EmailMessage = ElmUtilities.LinkCheck(ElmUtilities.WordAbreviations(body[2]), data);
            }
            else if (body.Length == 5)
            {
                EmailAddress = body[1];
                EmailMessage = body[2];
                IncidentCode = body[4];
                BranchCode = body[3];
                Subject = body[0];
            }
            else
            {
                throw new Exception("Please enter all Email details.");
            }
        }

        //Email constructor for import.
        public Email(string id, string subject, string emailAddress, string emailMessage, DataCollection data)
        {
            ID = id;
            EmailAddress = emailAddress;
            EmailMessage = ElmUtilities.LinkCheck(emailMessage, data);
            Subject = subject;
        }

        //SIR email constructor for import.
        public Email(string id, string subject, string emailAddress, string emailMessage, string branchCode, string incidentCode, DataCollection data)
        {
            ID = id;
            EmailAddress = emailAddress;
            EmailMessage = ElmUtilities.LinkCheck(emailMessage, data);
            IncidentCode = incidentCode;
            BranchCode = branchCode;
            Subject = subject;
        }


        //Below are all my Getter and Setters with built in validation and error handling.
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value.Length == 10)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("Message header ID must be 10 characters long.");
                }
            }
        }

        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                if (IncidentCode != null)
                {
                    //Regex to find date format dd/mm/yy as well as SIR
                    if (Regex.Match(value, @"([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{2}$").Success && value.Contains("SIR"))
                    {
                        _subject = value;
                    }
                    else
                    {
                        throw new Exception("Your subject needs to be between 1 and 20 and contain SIR as well as a date in dd/mm/yy format");
                    }
                }
                else if (value.Length > 0 && value.Length <= 20)
                {
                    _subject = value;
                }
                else
                {
                    throw new Exception("Your subject needs to be between 1 and 20 characters long");
                }
            }
        }


        public string EmailAddress
        {
            get
            {
                return _emailAddress;
            }
            set
            {
                if (value.Length > 0 && Regex.Matches(value, "([a-zA-Z0-9+._-]+@[a-zA-Z0-9._-]+.[a-zA-Z0-9_-]+)").Count == 1)
                {
                    _emailAddress = value;
                }
                else
                {
                    throw new Exception("Your Email Address is invalid.");
                }
            }
        }

        public string EmailMessage
        {
            get
            {
                return _emailMessage;
            }
            set
            {
                if (value.Length > 0 && value.Length <= 1028)
                {
                    _emailMessage = value;
                }
                else
                {
                    throw new Exception("Your Email Message needs to be between 1 and 1028 characters long");
                }
            }
        }

        public string BranchCode
        {
            get
            {
                return _branchCode;
            }
            set
            {
                if (value.Length == 9 && Regex.Matches(value, "([0-9]{2}-[0-9]{3}-[0-9]{2})").Count == 1)
                {
                    _branchCode = value;
                }
                else
                {
                    throw new Exception("Your branch code is invalid, enter the numerical format e.g. 12-345-67 - please ensure there are no accidental spaces left or right side of the commas.");
                }
            }
        }

        public string IncidentCode
        {
            get
            {
                return _incidentCode;
            }
            set
            {
                if (GetIncidentCode(value))
                {
                    _incidentCode = value;
                }
                else
                {
                    throw new Exception("Please enter a valid incident code.");
                }
            }
        }


        //DB acting as an end point API function here to check the input code against the incident codes List provided in the requirements
        private bool GetIncidentCode(string val)
        {
            DataCollection db = DataCollection.Instance();
            foreach (var item in db.incidentNature)
            {
                //softer comparison added to ensure an easy validation pass due to nature of incident
                if (val.ToLower().Contains(item.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}