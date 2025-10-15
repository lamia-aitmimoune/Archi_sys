namespace Universitedomain.DataAdapters;

public interface IEtudiantRepository
{
    Task<Etudiant> CreateAsync(Etudiant entity); // create
    Task UpdateAsync(Etudiant entity); //modify
    Task DeleteAsync(long id); // delete an id
    Task DeleteAsync(Etudiant entity); // delete
    Task<Etudiant?> FindAsync(long id); //chercher un etudiant par id
    Task<Etudiant?> FindAsync(params object[] keyValues); //chercher un etudiant par plusieurs valeurs 
    Task<List<Etudiant>> FindByConditionAsync(Expression<Func<Etudiant, bool>> condition); //find students with conditions
    Task<List<Etudiant>> FindAllAsync(); //find all student 
    Task SaveChangesAsync();
}