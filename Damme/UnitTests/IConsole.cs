namespace Damme
{
    public interface IConsole
    {
        /// <summary>
        /// Reading from the console method
        /// </summary>
        /// <returns></returns>
        string ReadLine();

        /// <summary>
        /// Writing in console method.
        /// </summary>
        /// <param name="outputString"></param>
        void WriteLine(string outputString);

        /// <summary>
        /// Clears the console
        /// </summary>
        void Clear();
    }
}