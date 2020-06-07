using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext_Meth_Deleg_Lambda_Linq
{

    //Problem 1. StringBuilder.Substring

    //Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
    //new StringBuilder and has the same functionality as Substring in the class String.

    public static class StringBuilderSubstring
    {

        public static StringBuilder Substring(this StringBuilder StrBuild, int index, int length)
        {
            var newStringBuilder = new StringBuilder();
            newStringBuilder.Append(StrBuild.ToString().Substring(index, length));
            return newStringBuilder;
        }
    }

}
