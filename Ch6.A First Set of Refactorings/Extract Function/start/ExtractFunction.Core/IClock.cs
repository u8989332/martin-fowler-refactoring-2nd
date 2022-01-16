using System;

namespace ExtractFunction.Core
{
    public interface IClock
    {
        DateTime Now { get; }
    }
}