namespace DemoClaseORMwinEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificandoDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "Categoria_Id" });
            RenameColumn(table: "dbo.Producto", name: "Categoria_Id", newName: "IdCategoria");
            AlterColumn("dbo.Producto", "IdCategoria", c => c.Int(nullable: false));
            CreateIndex("dbo.Producto", "IdCategoria");
            AddForeignKey("dbo.Producto", "IdCategoria", "dbo.Categoria", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "IdCategoria", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "IdCategoria" });
            AlterColumn("dbo.Producto", "IdCategoria", c => c.Int());
            RenameColumn(table: "dbo.Producto", name: "IdCategoria", newName: "Categoria_Id");
            CreateIndex("dbo.Producto", "Categoria_Id");
            AddForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria", "Id");
        }
    }
}
