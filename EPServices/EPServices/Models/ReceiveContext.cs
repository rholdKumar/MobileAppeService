using System;
namespace EPServices.Models
{
    public class ReceiveContext<T>
    {

        public bool Status { get; set; }
        public string ErrorMessage { get; set; }

        public T Result { get; set; }
    }
}
