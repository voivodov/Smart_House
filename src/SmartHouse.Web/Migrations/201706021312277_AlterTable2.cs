namespace SmartHouse.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArduinoDataModelPosts", "room1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ArduinoDataModelPosts", "room1");
        }
    }
}
