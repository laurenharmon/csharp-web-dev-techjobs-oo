using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string unavailable = "Data Not Available";
            string newline = "\n";
            string blankLine = " ";
            string blank = "";

                //wow i have to find a way to change this 
                if (Name == blank)
                {
                    Name = unavailable;
                }
                else if (this.EmployerName.Value == blank)
                {
                    EmployerName.Value = unavailable;
                }
                else if (EmployerLocation.Value == blank)
                {
                    EmployerLocation.Value = unavailable;
                }
                else if (JobType.Value == blank)
                {
                    JobType.Value = unavailable;
                }
                else if (JobCoreCompetency.Value == blank)
                {
                    JobCoreCompetency.Value = unavailable;
                }

                return blankLine + newline
                    + "ID: " + Id + newline
                    + "Name: " + Name + newline
                    + "Employer: " + EmployerName + newline
                    + "Location: " + EmployerLocation + newline
                    + "Position Type: " + JobType + newline
                    + "Core Competency: " + JobCoreCompetency + newline +
                    blankLine
                    ;
            //}
        }




    }
}
