using System.ComponentModel.DataAnnotations.Schema;

namespace Entityes.Notifications
{
    public class Notify
    {
        public Notify() 
        {
            Notifications = new List<Notify>();
        }

        [NotMapped]
        public string NameProperty { get; set; }
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public List<Notify> Notifications;

        public bool ValidatePropertyString(string value, string nameProperty)
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notify
                {
                    Message = "Campo Obrigatório",
                    NameProperty = nameProperty
                });

                return false;
            }
            return true;
        }
    }
}
