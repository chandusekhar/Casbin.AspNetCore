﻿using System;
using System.Security.Claims;
using Casbin.AspNetCore.Abstractions;

namespace Casbin.AspNetCore
{
    public class DefaultCasbinAuthorizationContextFactory : ICasbinAuthorizationContextFactory
    {
        public ICasbinAuthorizationContext CreateContext(
            ClaimsPrincipal user, ICasbinAuthorizationData data)
            => new CasbinAuthorizationContext(user, data);
    }
}
