namespace SmartHouse.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArduinoDataModelPosts", "in", c => c.Double(nullable: false));
            AddColumn("dbo.ArduinoDataModelPosts", "out", c => c.Double(nullable: false));
            AddColumn("dbo.ArduinoDataModelPosts", "hum", c => c.Double(nullable: false));
            AddColumn("dbo.ArduinoDataModelPosts", "time", c => c.String());
            DropColumn("dbo.ArduinoDataModelPosts", "indoorCelsius");
            DropColumn("dbo.ArduinoDataModelPosts", "outdoorCelsius");
            DropColumn("dbo.ArduinoDataModelPosts", "humidityProcent");
            DropColumn("dbo.ArduinoDataModelPosts", "relay1");
            DropColumn("dbo.ArduinoDataModelPosts", "relay2");
            DropColumn("dbo.ArduinoDataModelPosts", "relay3");
            DropColumn("dbo.ArduinoDataModelPosts", "relay4");
            DropColumn("dbo.ArduinoDataModelPosts", "dateSend");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ArduinoDataModelPosts", "dateSend", c => c.String());
            AddColumn("dbo.ArduinoDataModelPosts", "relay4", c => c.String());
            AddColumn("dbo.ArduinoDataModelPosts", "relay3", c => c.String());
            AddColumn("dbo.ArduinoDataModelPosts", "relay2", c => c.String());
            AddColumn("dbo.ArduinoDataModelPosts", "relay1", c => c.String());
            AddColumn("dbo.ArduinoDataModelPosts", "humidityProcent", c => c.Double(nullable: false));
            AddColumn("dbo.ArduinoDataModelPosts", "outdoorCelsius", c => c.Double(nullable: false));
            AddColumn("dbo.ArduinoDataModelPosts", "indoorCelsius", c => c.Double(nullable: false));
            DropColumn("dbo.ArduinoDataModelPosts", "time");
            DropColumn("dbo.ArduinoDataModelPosts", "hum");
            DropColumn("dbo.ArduinoDataModelPosts", "out");
            DropColumn("dbo.ArduinoDataModelPosts", "in");
        }
    }
}
