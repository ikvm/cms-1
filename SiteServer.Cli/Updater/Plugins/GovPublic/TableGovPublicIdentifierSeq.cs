﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Plugins.GovPublic
{
    public partial class TableGovPublicIdentifierSeq
    {
        [JsonProperty("seqID")]
        public long SeqId { get; set; }

        [JsonProperty("publishmentSystemID")]
        public long PublishmentSystemId { get; set; }

        [JsonProperty("nodeID")]
        public long NodeId { get; set; }

        [JsonProperty("departmentID")]
        public long DepartmentId { get; set; }

        [JsonProperty("addYear")]
        public long AddYear { get; set; }

        [JsonProperty("sequence")]
        public long Sequence { get; set; }
    }

    public partial class TableGovPublicIdentifierSeq
    {
        public const string OldTableName = "GovPublicIdentifierSeq";

        public static readonly string NewTableName = "ss_govpublic_identifier_seq";

        public static readonly List<TableColumn> NewColumns = new List<TableColumn>
        {
            new TableColumn
            {
                AttributeName = "Id",
                DataType = DataType.Integer,
                IsPrimaryKey = true,
                IsIdentity = true
            },
            new TableColumn
            {
                AttributeName = "SiteId",
                DataType = DataType.Integer
            },
            new TableColumn
            {
                AttributeName = "ChannelId",
                DataType = DataType.Integer
            },
            new TableColumn
            {
                AttributeName = "DepartmentId",
                DataType = DataType.Integer
            },
            new TableColumn
            {
                AttributeName = "AddYear",
                DataType = DataType.Integer
            },
            new TableColumn
            {
                AttributeName = "Sequence",
                DataType = DataType.Integer
            }
        };

        public static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {"Id", nameof(SeqId)},
                {"SiteId", nameof(PublishmentSystemId)},
                {"ChannelId", nameof(NodeId)}
            };

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
