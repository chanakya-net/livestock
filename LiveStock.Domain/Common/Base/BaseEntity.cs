namespace LiveStock.Domain.Common.Base;

public abstract class BaseEntity(Guid id)
{
    protected Guid Id { get; } = id;
    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        return ((BaseEntity)obj).Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    protected BaseEntity() : this(Guid.NewGuid())
    { }
}