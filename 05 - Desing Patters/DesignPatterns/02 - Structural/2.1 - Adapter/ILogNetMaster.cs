using System;

namespace DesignPatterns
{
    //TRABALHA DE OUTRA FORMA

    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}