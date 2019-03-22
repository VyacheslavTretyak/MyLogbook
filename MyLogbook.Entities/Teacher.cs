﻿using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("teachers")]
    public class Teacher:DbEntity
    {
        [Column("firstName")]
        [StringLength(64)]
        public string FirstName { get; set; }

        [Column("lastName")]
        [StringLength(64)]
        public string LastName { get; set; }
		public virtual List<Group> Groups{ get; set; }
		public virtual List<Subject> Subjects{ get; set; }
		public virtual List<Mark> Marks{ get; set; }


		
    }
}
