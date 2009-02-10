using System.Xml;

namespace NMG.Core
{
    public class SqlMappingGenerator : BaseMappingGenerator 
    {
        public SqlMappingGenerator(string path, string tableName, string nameSpace, string assemblyName, ColumnDetails columnDetails) : base(path, tableName, nameSpace, assemblyName, string.Empty, columnDetails)
        {
        }

        protected override void AddGenerator(XmlDocument xmldoc, XmlElement idElement)
        {
            var generatorElement = xmldoc.CreateElement("generator");
            generatorElement.SetAttribute("class", "identity");
            idElement.AppendChild(generatorElement);
        }
    }
}