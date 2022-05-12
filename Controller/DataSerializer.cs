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

        public static bool SaveSessionData(SessionData data, string filename)
        {
            Stream stream = null;

            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, data);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Serialization failed!" + ex.ToString());
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

        public static SessionData LoadSessionData(string filename)
        {
            Stream stream = null;
            SessionData loadedData = null;

            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
                loadedData = (SessionData)formatter.Deserialize(stream);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("...Attempted to fetch file '" + ex.FileName + "' which was not found.");

            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }

            return loadedData;  
        }
    }
}
