﻿using Microsoft.Extensions.DependencyInjection;
using PlanShare.Infrastructure.DataAccess;

namespace PlanShare.Infrastructure.Migrations
{
    public static class DataBaseMigration
    {
        public async static Task MigrationDatabase(IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<PlanShareDbContext>();

            await dbContext.Database.MigrateAsync();
        }
    }
}
