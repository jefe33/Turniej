namespace Projekt.Exceptions
{
    public class EmptyTeamException : ProjectException
    {
        public EmptyTeamException(string msg) : base(msg){}
    }
}