using ProjetDLL.Encapsulation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetDLL
{
    public class Tools
    {
        //Méthode de Sauvegarde XML
        public static void ExportXML(string path, List<CompteBancaire> listCB)
        {
            FileStream fs = new FileStream(path, FileMode.Create);

            XmlSerializer serializer = new XmlSerializer(listCB.GetType());
            serializer.Serialize(fs, listCB);

            fs.Close();
        }

        //Extraire(lecture) le fichier XML
        public static List<CompteBancaire> ImportXML(string path)
        {
            List<CompteBancaire> lstCB = new List<CompteBancaire>();
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);

                XmlSerializer ser = new XmlSerializer(lstCB.GetType());
                lstCB  = (List<CompteBancaire>)ser.Deserialize(fs);

                fs.Close();
            } else
            {
                throw new Exception("Fichier XML introuvable");
            }

            return lstCB;
        }
    }
}
