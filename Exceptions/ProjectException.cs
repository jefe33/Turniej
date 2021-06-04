using System;

namespace Projekt.Exceptions
{
    public class ProjectException : Exception
    {
        public ProjectException(string msg) : base(msg){}
    }
}