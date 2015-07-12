using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Czechicoach.Models
{
    public class Coach
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

        public Location Location { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }
        
         
    }

    public enum Location
    {
        Praha,
        Brno,
        Ostrava,
        Liberec,
        HradecKralove,
        Plzen,
        Olomouc
    }

    public class Skill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Coach> Coaches { get; set; }

        //Html,
        //Css,
        //Javascript,
        //Csharp,
        //Ruby,
        //Android,
        //Java,
        //Gimp,
        //Inkscape,
        //Wordpress,
        //Php,
        //Python,
        //Ux,
        //Excel
    }

    //public class CoachSkill
    //{
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public Guid Id { get; set; }

    //    [Required]
    //    public virtual Coach Coach { get; set; }

    //    [Required]
    //    public virtual Skill Skill { get; set; }

    //}
}