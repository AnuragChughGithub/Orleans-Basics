using System;
using System.Collections.Generic;
using System.Text;

namespace OrleansBasics.Client.OrleansFunctionExamples;

public interface IOrleansFunctionProvider
{
    IList<IOrleansFunction> GetOrleansFunctions();
}