using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Model
{
    public enum Genders
    {
        Female,
        Male,
        Intersex,
        Transgender
    }
    public enum Suburbs
    {
        Walmer = 101,
        Summerstrand,
        Humewood,
        SouthEnd,
        ForestHill,
        Schoenmakerskop,
        LovemorePark,
        NorthEnd,
        Korsten,
        WesternHills
    }

    public enum Relationships
    {
        Son,
        GrandMother,
        Daughter,
        GrandFather,
        Wife,
        Mother,
        Father,
        Brother,
        Sister,
        GrandChild,
        Husband

    }
    public enum TestRequestStatus
    {
        New,
        Cancelled,
        Assigned,
        Scheduled,
        Performed,
        AtLab,
        Closed
    }

    public enum Rank
    {
        General,
        Enrolled,
        Specialized,
        Midwife

    }
}
