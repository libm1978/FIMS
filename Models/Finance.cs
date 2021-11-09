using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIMS.Models
{
    public class Finance
    {
        public Guid ID {get;set;}
        public string Name {get;set;}
        public string Description {get;set;}
        public Guid Source {get;set;}
        public Guid Purpose {get;set;}
        public Guid Department {get;set;}
        public bool IsDisabled {get;set;}
    }
}