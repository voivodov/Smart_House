namespace SmartHouse.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableArduinoAddedDateSend : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArduinoDataModelPosts", "dateSend", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ArduinoDataModelPosts", "dateSend");
        }
    }
}
