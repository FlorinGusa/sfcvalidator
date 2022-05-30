using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfcdashboard.Utils
{
    public sealed class IronPy
    {
        private static readonly IronPy instance = new IronPy();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static IronPy()
        {
        }

        public static void executeTest()
        {
            Microsoft.Scripting.Hosting.ScriptEngine pythonEngine =
          IronPython.Hosting.Python.CreateEngine();
            Microsoft.Scripting.Hosting.ScriptSource pythonScript =
                pythonEngine.CreateScriptSourceFromString("print 'Hello World!'");
            pythonScript.Execute();

        }

        private IronPy()
        {
        }

        public static IronPy Instance
        {
            get
            {
                return instance;
            }
        }



    }
}
