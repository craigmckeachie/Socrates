using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Socrates.DataAccess
{
    public static class SocratesContextFactory
    {
        public static ISocratesContext GetContext(string connStr, bool useProxies = true)
        {

            var context = new SocratesContext(connStr, useProxies);
            context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            return context;

            // return new SocratesContext(connStr, useProxies);
        }
    }
}