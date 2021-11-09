using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIMS.Models
{
    public class FinancePolicy
    {
        public Guid ID {get;set;}
        public string Name {get;set;}
        public string Url {get;set;}
        public string FileName {get;set;}
    }
}