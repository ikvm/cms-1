﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model41
{
    public partial class TablePermissionsInRoles
    {
        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("generalPermissions")]
        public string GeneralPermissions { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class TablePermissionsInRoles
    {
        public const string OldTableName = "PermissionsInRoles";

        public static readonly string NewTableName = DataProvider.PermissionsInRolesDao.TableName;

        public static readonly List<TableColumn> NewColumns = DataProvider.PermissionsInRolesDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertKeyDict = null;

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
