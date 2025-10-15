namespace UniversiteDomain.Exceptions.EtudiantExceptions;

[Serializable] // un fichier, ou à travers le réseau specifier
public class DuplicateNumEtudException : Exception  // Elle herite de la classe Exeption  :
{
    public DuplicateNumEtudException() : base() { } // renvoie rien 
    public DuplicateNumEtudException(string message) : base(message) { } // renvoie un message personnalisé
    public DuplicateNumEtudException(string message, Exception inner) : base(message, inner) { } //renvoie un message perso et l'erreur lier 
    
}
// comment fonctionne le serializable 