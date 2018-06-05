﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;
using SiteServer.Utils;

namespace SiteServer.Cli.Updater.Model50
{
    public partial class TableContent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nodeID")]
        public long NodeId { get; set; }

        [JsonProperty("publishmentSystemID")]
        public long PublishmentSystemId { get; set; }

        [JsonProperty("addUserName")]
        public string AddUserName { get; set; }

        [JsonProperty("lastEditUserName")]
        public string LastEditUserName { get; set; }

        [JsonProperty("writingUserName")]
        public string WritingUserName { get; set; }

        [JsonProperty("lastEditDate")]
        public DateTimeOffset LastEditDate { get; set; }

        [JsonProperty("taxis")]
        public long Taxis { get; set; }

        [JsonProperty("contentGroupNameCollection")]
        public string ContentGroupNameCollection { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("sourceID")]
        public long SourceId { get; set; }

        [JsonProperty("referenceID")]
        public long ReferenceId { get; set; }

        [JsonProperty("isChecked")]
        public string IsChecked { get; set; }

        [JsonProperty("checkedLevel")]
        public long CheckedLevel { get; set; }

        [JsonProperty("comments")]
        public long Comments { get; set; }

        [JsonProperty("photos")]
        public long Photos { get; set; }

        [JsonProperty("hits")]
        public long Hits { get; set; }

        [JsonProperty("hitsByDay")]
        public long HitsByDay { get; set; }

        [JsonProperty("hitsByWeek")]
        public long HitsByWeek { get; set; }

        [JsonProperty("hitsByMonth")]
        public long HitsByMonth { get; set; }

        [JsonProperty("lastHitsDate")]
        public DateTimeOffset LastHitsDate { get; set; }

        [JsonProperty("settingsXML")]
        public string SettingsXml { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subTitle")]
        public object SubTitle { get; set; }

        [JsonProperty("imageUrl")]
        public object ImageUrl { get; set; }

        [JsonProperty("videoUrl")]
        public object VideoUrl { get; set; }

        [JsonProperty("fileUrl")]
        public object FileUrl { get; set; }

        [JsonProperty("linkUrl")]
        public object LinkUrl { get; set; }

        [JsonProperty("content")]
        public object Content { get; set; }

        [JsonProperty("summary")]
        public object Summary { get; set; }

        [JsonProperty("author")]
        public object Author { get; set; }

        [JsonProperty("source")]
        public object Source { get; set; }

        [JsonProperty("isRecommend")]
        public string IsRecommend { get; set; }

        [JsonProperty("isHot")]
        public string IsHot { get; set; }

        [JsonProperty("isColor")]
        public string IsColor { get; set; }

        [JsonProperty("isTop")]
        public string IsTop { get; set; }

        [JsonProperty("addDate")]
        public DateTimeOffset AddDate { get; set; }
    }

    public partial class TableContent
    {
        public static List<TableColumn> GetNewColumns(List<TableColumn> oldColumns)
        {
            var columns = new List<TableColumn>();
            foreach (var tableColumnInfo in oldColumns)
            {
                if (StringUtils.EqualsIgnoreCase(tableColumnInfo.AttributeName, nameof(NodeId)))
                {
                    tableColumnInfo.AttributeName = nameof(ContentInfo.ChannelId);
                }
                else if (StringUtils.EqualsIgnoreCase(tableColumnInfo.AttributeName, nameof(PublishmentSystemId)))
                {
                    tableColumnInfo.AttributeName = nameof(ContentInfo.SiteId);
                }
                else if (StringUtils.EqualsIgnoreCase(tableColumnInfo.AttributeName, nameof(ContentGroupNameCollection)))
                {
                    tableColumnInfo.AttributeName = nameof(ContentInfo.GroupNameCollection);
                }
                columns.Add(tableColumnInfo);
            }

            return columns;
        }

        public static readonly Dictionary<string, string> ConvertKeyDict =
            new Dictionary<string, string>
            {
                {nameof(ContentInfo.ChannelId), nameof(NodeId)},
                {nameof(ContentInfo.SiteId), nameof(PublishmentSystemId)},
                {nameof(ContentInfo.GroupNameCollection), nameof(ContentGroupNameCollection)}
            };

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
