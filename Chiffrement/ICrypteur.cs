namespace Chiffrement
{
    public enum TypeChiffrement
    {
        Cesar,
        Substitution
    }

    public interface ICrypteur
    {
        TypeChiffrement TypeCh { get; set; }

        string crypting(string StringToCrypt);
    }

    /* public class ChriffrementCesar : ICrypteur
     {
      //   TypeCh = TypeChiffrement.Cesar;

         public string crypting(string StringToCrypt)
         {
             return null;
         }
     }*/
}