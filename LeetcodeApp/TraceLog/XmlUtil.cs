using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LeetcodeApp.TraceLog
{
    /// <summary>
    /// XML操作类
    /// </summary>
    public class XmlUtil
    {
        #region Model与XML互相转换 

        /// <summary>   
        /// Model转化为XML的方法   
        /// </summary>   
        /// <param name="model">要转化的Model</param>  
        /// <returns></returns>   
        public static string ModelToXML(object modelCurrent, object modelOriginal, OperationType operationType)
        {
            bool updateFlag = false;

            XmlDocument xmldoc = new XmlDocument();
            XmlDeclaration dec = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);

            XmlElement root = xmldoc.DocumentElement;
            xmldoc.InsertBefore(dec, root);

            XmlElement RootNode = xmldoc.CreateElement("Opreation");
            RootNode.Attributes.Append(CreateAttribute(RootNode, "Type", operationType.ToString()));
            xmldoc.AppendChild(RootNode);

            string nodeName = string.Empty;
            switch(operationType)
            {
                case OperationType.CREATE: nodeName = "current"; break;
                case OperationType.DELETE: nodeName = "original"; break;
                case OperationType.UPDATE: nodeName = "original"; updateFlag = true; break;
            }

            if (modelCurrent != null)
            {
                XmlElement ModelNode = xmldoc.CreateElement(nodeName);
                ModelNode.Attributes.Append(CreateAttribute(ModelNode, "Type", modelCurrent.GetType().Name.ToString()));
                RootNode.AppendChild(ModelNode);

                foreach (PropertyInfo property in modelCurrent.GetType().GetProperties())
                {
                    XmlElement attribute = xmldoc.CreateElement(property.Name);
                    if (property.GetValue(modelCurrent, null) != null)
                        attribute.InnerText = property.GetValue(modelCurrent, null).ToString();
                    else
                        attribute.InnerText = "[Null]";
                    ModelNode.AppendChild(attribute);
                }
            }

            if(modelOriginal != null && updateFlag)
            {
                nodeName = "current";

                XmlElement ModelNode = xmldoc.CreateElement(nodeName);
                ModelNode.Attributes.Append(CreateAttribute(ModelNode, "Type", modelCurrent.GetType().Name.ToString()));
                RootNode.AppendChild(ModelNode);

                foreach (PropertyInfo property in modelOriginal.GetType().GetProperties())
                {
                    XmlElement attribute = xmldoc.CreateElement(property.Name);
                    if (property.GetValue(modelOriginal, null) != null)
                        attribute.InnerText = property.GetValue(modelOriginal, null).ToString();
                    else
                        attribute.InnerText = "[Null]";
                    ModelNode.AppendChild(attribute);
                }
            }

            return xmldoc.OuterXml;
        }

        /// <summary>   
        /// XML转化为Model的方法   
        /// </summary>   
        /// <param name="xml">要转化的XML</param>  
        /// <param name="SampleModel">Model的实体示例，New一个出来即可</param>  
        /// <returns></returns>   
        public static object XMLToModel(string xml, object SampleModel)
        {
            if (string.IsNullOrEmpty(xml))
                return SampleModel;
            else
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xml);

                XmlNodeList attributes = xmldoc.SelectSingleNode("Model").ChildNodes;
                foreach (XmlNode node in attributes)
                {
                    foreach (PropertyInfo property in SampleModel.GetType().GetProperties())
                    {
                        if (node.Name == property.Name)
                        {
                            if (node.InnerText != "[Null]")
                            {
                                if (property.PropertyType == typeof(System.Guid))
                                    property.SetValue(SampleModel, new Guid(node.InnerText), null);
                                else
                                    property.SetValue(SampleModel, Convert.ChangeType(node.InnerText, property.PropertyType), null);
                            }
                            else
                                property.SetValue(SampleModel, null, null);
                        }
                    }
                }
                return SampleModel;
            }
        }

        #endregion

        public static XmlAttribute CreateAttribute(XmlNode node, string attributeName, string value)
        {
            try
            {
                XmlDocument doc = node.OwnerDocument;
                XmlAttribute attr = null;
                attr = doc.CreateAttribute(attributeName);
                attr.Value = value;
                node.Attributes.SetNamedItem(attr);
                return attr;
            }
            catch (Exception err)
            {
                string desc = err.Message;
                return null;
            }
        }
    }
}
