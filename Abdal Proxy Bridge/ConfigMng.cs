using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Abdal_Proxy_Bridge
{
    internal class ConfigMng
    {

        public static void ConfigFileWriter(string title,string value)
        {
            var current_exe_dir = System.Environment.CurrentDirectory;
            XmlTextWriter _4iProtoConfigWriter = new XmlTextWriter(current_exe_dir + "\\4iServerConfig.4ipc", System.Text.Encoding.UTF8);
            // Opens the document
            _4iProtoConfigWriter.WriteStartDocument();
            // Write  element
            _4iProtoConfigWriter.WriteStartElement(title, "");
            _4iProtoConfigWriter.WriteString(value);
            _4iProtoConfigWriter.WriteEndElement();
            // Ends the document.
            _4iProtoConfigWriter.WriteEndDocument();
            // close writer
            _4iProtoConfigWriter.Close();

        }
    }
}
