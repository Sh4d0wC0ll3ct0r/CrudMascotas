namespace AppMascotas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MascotaAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mascotas",
                c => new
                    {
                        MascotaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Raza = c.String(),
                        Dueño = c.String(),
                        Edad = c.Int(nullable: false),
                        ColorPelo = c.String(),
                    })
                .PrimaryKey(t => t.MascotaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mascotas");
        }
    }
}
