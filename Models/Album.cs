﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SavinaMusicLab.Models
{
    public class Album
    {
        public Album()
        {
            Songs = new List<Song>();
        }

        public int Id { get; set; }
        [Display(Name = "Назва альбому")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Уведіть від 2 до 50 символів")]
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        public string Name { get; set; }
        [Display(Name = "Рік виходу альбому")]
        [Range(1600, 2020, ErrorMessage = "Уведіть рік від 1600 до поточного")]
        public int? Year { get; set; }

        public int BandId { get; set; }
        [Display(Name = "Група")]
        public virtual Band Band { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
