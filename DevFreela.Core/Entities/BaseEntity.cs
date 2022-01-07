namespace DevFreela.Core.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
        }

        public int Id { get; private set; }
    }
}
