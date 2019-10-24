using CSGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGeneratorFromCommandLine
{
    
    class Start
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region base functions

        private static string GetAppConfigStringParameter(string name)
        {

            return ConfigurationManager.AppSettings.Get(name);

        }

        static void Main(string[] args)
        {

            //Date: 2019. 10. 24. 20:55

            //className
            log.Debug("path:" + GetAppConfigStringParameter(args[4]));

            try
            {
                //inpput path, language extension, output path, default namespace
                Program.MainMethod(args[0], args[1], args[2], args[3]);
            } catch (Exception _exception)
            {
                log.Error(_exception.Message);
            }
        }
    }
}
