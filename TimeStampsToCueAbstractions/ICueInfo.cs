using System.Collections.Generic;

namespace TimeStampsToCueAbstractions
{
    public interface ICueInfo
    {
        string FilePath { get;  }
        string Title { get;  }
        ICollection<ICueElement> Elements { get; }
    }
}