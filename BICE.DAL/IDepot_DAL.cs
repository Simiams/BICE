namespace BICE.DAL;

public interface IDepot_DAL<Type_DAL>
{
    public Type_DAL Insert(Type_DAL p);
    public Type_DAL Update(Type_DAL p);
    public Type_DAL GetById(int id);
    public IEnumerable<Type_DAL> GetAll();
    public void Delete(Type_DAL p);
}