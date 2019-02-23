using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SighIn.demo
{
    public class Events: DomainModel
    {
        public String OrganizerDisplayName { get; set; }

        public String OrganizerId { get; set; }

        public String TimeRange { get; set; }
        public String Topic { get; set; }
        public String Dscription { get; set; }
        public DateTime CreatedTime { get; set; }
       

    }

    public class CheckIn
    {
        public String ParticipatorId { get; set; }
        public String ParticipatorDisplayName { get; set; }
        public DateTime CheckInTime { get; set; }
    }
}

