using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public class JobOpening
    {
        private string _title;
        private string _desc;
        private string _pay;
        private static List<JobOpening> _jobOpenings = new List<JobOpening>();

        public void SetTitle(string newTitle)
        {
            _title = newTitle;
        }

        public void SetDesc(string newDesc)
        {
            _desc = newDesc;
        }

        public void SetPay(string newPay)
        {
            _pay = newPay;
        }

        public string GetTitle()
        {
            return _title;
        }
        public string GetDesc()
        {
            return _desc;
        }
        public string GetPay()
        {
            return _pay;
        }

        public void Save()
        {
            _jobOpenings.Add(this);
        }

        public static List<JobOpening> GetJobOpenings()
        {
            return _jobOpenings;
        }
        public static void ClearList()
        {
            _jobOpenings.Clear();
        }
    }
}
