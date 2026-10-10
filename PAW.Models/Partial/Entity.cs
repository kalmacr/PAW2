using System.ComponentModel.DataAnnotations.Schema;

namespace PAW.Models;
    public interface IEntity
    {
    [NotMapped]
    Guid Id { get; set; }
    [NotMapped]
    string Coments { get; set; }
    [NotMapped]
    DateOnly CreatedDate { get; set; }
    [NotMapped]
    DateTime ModifieldDate { get; set;

}

    public class Entity : IEntity 
    {
        [NotMapped]
        public Guid Id { get; set; }
        [NotMapped]
        public string Coments { get ; set ; }
        [NotMapped]
        public DateOnly CreatedDate { get ; set ; }
        [NotMapped]
        public DateTime ModifieldDate { get ; set ; }
    }
}
