using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIMS.Models
{
    public class FinancePurpose
    {
        public Guid ID {get;set;}
        public string Name {get;set;}
    }
}