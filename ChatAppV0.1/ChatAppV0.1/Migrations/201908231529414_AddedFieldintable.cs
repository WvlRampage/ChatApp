namespace ChatAppV0._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFieldintable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nick", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Nick");
        }
    }
}
