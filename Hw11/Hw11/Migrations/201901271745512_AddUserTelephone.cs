namespace Hw11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTelephone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Telephone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Telephone");
        }
    }
}
