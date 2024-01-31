using Microsoft.AspNetCore.Mvc.Rendering; // Pour SelectList

namespace HarmonieSanteParamedicalMonolithic.Models
{
    public class ConsultantModel
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Speciality { get; set; }
    }

    public class ConsultantModelList
    {
        public List<ConsultantCalendarModel> ConsultantCalendars { get; set; }
        public List<ConsultantModel> Consultants { get; set; }

        public ConsultantModelList(List<ConsultantModel> consultants)
        {
            Consultants = consultants;
        }

        public int SelectedConsultantId { get; set; }
        public SelectList ConsultantsList { get; set; }
    }
}
