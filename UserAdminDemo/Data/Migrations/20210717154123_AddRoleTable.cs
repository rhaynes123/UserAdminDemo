using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAdminDemo.Data.Migrations
{
    public partial class AddRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string RoleCreationSql = @"DROP TABLE IF EXISTS Role;
                    CREATE TABLE Role (
                        Id INTEGER NOT NULL CONSTRAINT PK_Role PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NULL,
                        Active INTEGER NOT NULL,
                        Description TEXT NOT NULL,
                        DateAdded TEXT NOT NULL,
                        DateModified TEXT NULL,
                        DateDeactivated TEXT  NULL);

                    INSERT INTO Role(Name,Active,Description,DateAdded, DateModified, DateDeactivated)
                    VALUES('Admin', 1,'Site Admin',DateTime('now'),DateTime('now'),Null);

                    INSERT INTO Role(Name,Active,Description,DateAdded, DateModified, DateDeactivated)
                    VALUES('Owner', 1,'Company Owner',DateTime('now'),DateTime('now'),Null);

                    INSERT INTO Role(Name,Active,Description,DateAdded, DateModified, DateDeactivated)
                    VALUES('Manager', 1,'Team Manager',DateTime('now'),DateTime('now'),Null);

                    INSERT INTO Role(Name,Active,Description,DateAdded, DateModified, DateDeactivated)
                    VALUES('Employee', 1,'Company Employee',DateTime('now'),DateTime('now'),Null);
                    ";
            migrationBuilder.Sql(RoleCreationSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string RoleDropSql = @"DROP TABLE IF EXISTS Role;";
                    
            migrationBuilder.Sql(RoleDropSql);
        }
    }
}
