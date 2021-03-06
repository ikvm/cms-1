﻿namespace SiteServer.CMS.Api.V1
{
    public static class ApiUsersRoute
    {
        public const string UsersRoute = "v1/users";
        public const string UserRoute = "v1/users/{id}";
        public const string ActionsLoginRoute = "v1/users/actions/login";

        public class ActionsLoginBody
        {
            public string Account { get; set; }
            public string Password { get; set; }
        }
    }
}