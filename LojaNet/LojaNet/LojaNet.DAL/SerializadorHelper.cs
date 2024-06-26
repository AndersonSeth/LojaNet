﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace LojaNet.DAL
{
    public static class SerializadorHelper
    {
        public static void Serializar(string arquivo, object dados)
        {
            using(var stream=new StreamWriter(arquivo)) 
            {
                var Serializador = new XmlSerializer(dados.GetType());
                Serializador.Serialize(stream, dados);
            }

        }

        public static object Deserializar (string arquivo, Type tipo)
        {
            object retorno = null;
            using(var stream = new StreamReader(arquivo)) 
            {
                var serializador = new XmlSerializer(tipo);
                retorno = serializador.Deserialize(stream);
            }
            return retorno;
        }
    }
}
