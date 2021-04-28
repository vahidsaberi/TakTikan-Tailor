using System.Collections.Generic;

namespace TakTikan.Tailor.Dto
{
    public class SeamstressDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ICollection<SewnPiece> SewnPieces { get; set; }
    }
}
