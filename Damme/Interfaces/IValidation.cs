namespace Damme
{
    public interface IValidation
    {
        bool Validate(Pion pionToMove, int xTo, int yTo, Pion[,] mainField, char player);
    }
}