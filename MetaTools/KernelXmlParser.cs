using System.Data;
using System.Linq;
using System.Xml.Linq;
using MetaTools.Model;

namespace MetaTools
{

    public class KernelXmlParser
    {
        private readonly DsK3Cloud _dsK3Cloud;

        public KernelXmlParser(DsK3Cloud dsK3Cloud)
        {
            this._dsK3Cloud = dsK3Cloud;
        }

        public void ParseXml(string xmlContent)
        {
            XDocument xdoc = XDocument.Parse(xmlContent);
            // 处理Entity节点
            string headEntityKey = ProcessEntities(xdoc);
            // 处理Field节点
            ProcessFields(xdoc, headEntityKey);

        }

        private string ProcessEntities(XDocument xdoc)
        {
            string headEntityKey = "";
            var nodeFrm = xdoc.Descendants("Form").FirstOrDefault();
            string frmId ="";
            string frmName = "";
            if (nodeFrm != null)
            {
                 frmId = nodeFrm.Element("Id")?.Value ?? "";
                 frmName = nodeFrm.Element("Name")?.Value ?? "";
            }
            foreach (var element in xdoc.Descendants().Where(n => n.Name.LocalName.EndsWith("Entity")))
            {
                string entityType = element.Name.LocalName;
                string tableName = element.Element("TableName")?.Value ?? "";

                // 处理HeadEntity的特殊逻辑
                bool isHeadEntity = entityType == "HeadEntity";

                string key = isHeadEntity
                    ? element.Element("Key")?.Value ?? tableName
                    : element.Element("Key")?.Value ?? "";

                string id = isHeadEntity
                    ? element.Element("Id")?.Value ?? tableName
                    : element.Element("Id")?.Value ?? "";

                int seq = isHeadEntity
                    ? 0
                    : int.Parse(element.Element("Seq")?.Value ?? "0");

                string entryPk = isHeadEntity
                    ? element.Element("EntryPkFieldName")?.Value ?? tableName
                    : element.Element("EntryPkFieldName")?.Value ?? "";

                string entryName = isHeadEntity
                    ? element.Element("EntryName")?.Value ?? tableName
                    : element.Element("EntryName")?.Value ?? "";

                // 添加行数据
                DataRow row = _dsK3Cloud.EntityTable.NewRow();
                row["Key"] = key;
                row["Id"] = id;
                row["Name"] = element.Element("Name")?.Value ?? "";
                row["TableName"] = tableName;
                row["Seq"] = seq;
                row["EntryPkFieldName"] = entryPk;
                row["EntryName"] = entryName;
                row["EntityType"] = entityType;
                row["FrmID"] = frmId;
                row["FrmName"] = frmName;
                _dsK3Cloud.EntityTable.Rows.Add(row);

                if (isHeadEntity) headEntityKey = key;
            }

            return headEntityKey;
        }

        private void ProcessFields(XDocument xdoc, string headEntityKey)
        {
            foreach (var element in xdoc.Descendants().Where(n => n.Name.LocalName.EndsWith("Field")))
            {
                DataRow row = _dsK3Cloud.FieldTable.NewRow();
                row["Key"] = element.Element("Key")?.Value ?? "";
                row["Name"] = element.Element("Name")?.Value ?? "";
                row["FieldName"] = element.Element("FieldName")?.Value ?? "";
                row["PropertyName"] = element.Element("PropertyName")?.Value ?? "";
                row["EntityKey"] = element.Element("EntityKey")?.Value ?? headEntityKey;
                row["FieldType"] = element.Name.LocalName;
                _dsK3Cloud. FieldTable.Rows.Add(row);
            }
        }



    }



}
