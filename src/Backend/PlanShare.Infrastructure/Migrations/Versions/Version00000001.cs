using FluentMigrator;

namespace PlanShare.Infrastructure.Migrations.Versions
{
    [Migration(DatabaseVersion.TABLE_REGISTER_USER, "Create table to save the user's information")]
    public class Version00000001 : ForwardOnlyMigration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
                .WithColumn("Active").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("Name").AsString(256).NotNullable()
                .WithColumn("Email").AsString(256).NotNullable()
                .WithColumn("CreatedOn").AsDateTime().NotNullable()
                .WithColumn("Password").AsString(2000).NotNullable();

        }
    }
}
