using SGF_ROHAN_WF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace SGF_ROHAN_WF.Controller
{

    public class DataSerializer
    {

        const int VERSION = 1;


        public static bool SaveCurrentSession(SessionData data, string fname)
        {
            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fname, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, VERSION);
                formatter.Serialize(stream, data);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
            finally
            {
                if(stream != null)
                {
                    stream.Close();
                }
                
            }
            return true;

        }

        public static SessionData Load(string fname)
        {
            Stream stream = null;
            SessionData currData = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fname, FileMode.Open, FileAccess.Read, FileShare.None);
                int version = (int)formatter.Deserialize(stream);
                Debug.Assert(version == VERSION);
                currData = (SessionData)formatter.Deserialize(stream);
            }
            catch
            {
                // do nothing, just ignore any possible errors. What!
            }
            finally
            {
                if (null != stream)
                    stream.Close();
            }
            return currData;
        }

    }
}
