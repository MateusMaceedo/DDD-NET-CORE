using ProjetoModeloDDD.Domain.Enum;

namespace ProjetoModeloDDD.Domain.Base
{
    public class BaseEntity
    {
        public Status Status { get; set; }

        public virtual void Update(Status status)
        {
          this.Status = status;
        }
    }
}
