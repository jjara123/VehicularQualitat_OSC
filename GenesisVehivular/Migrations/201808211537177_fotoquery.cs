namespace GenesisVehivular.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fotoquery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.t_foto",
                c => new
                    {
                        idimagen = c.Int(nullable: false, identity: true),
                        codinspeccion = c.Int(nullable: false),
                        hora = c.DateTime(),
                        descripcion = c.String(),
                        imagen = c.Binary(),
                    })
                .PrimaryKey(t => t.idimagen);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.t_foto");
        }
    }
}
