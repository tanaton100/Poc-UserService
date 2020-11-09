using System;

namespace AdvancedInfoService.Mimo.GitLabService.Commons.Types
{
    public class StrategyException : Exception
    {
        public string Code { get; }

        public StrategyException()
        {
        }

        public StrategyException(string code)
        {
            Code = code;
        }

        public StrategyException(string message, params object[] args) 
            : this(string.Empty, message, args)
        {
        }

        public StrategyException(string code, string message, params object[] args) 
            : this(null, code, message, args)
        {
        }

        public StrategyException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public StrategyException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }        
    }
}