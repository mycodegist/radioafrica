using System.Data;

namespace RadioAfrica.Domain.Entities
{
    public class Radio
    {
        public string Name { get; set; }
        public float Frequency { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}