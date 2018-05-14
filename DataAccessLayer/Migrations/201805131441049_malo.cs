namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class malo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Content = c.String(nullable: false),
                        KeyWords = c.String(maxLength: 200),
                        ViewCount = c.Int(nullable: false),
                        IsDraft = c.Boolean(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedUserName = c.String(maxLength: 30),
                        Category_Id = c.Short(),
                        CreteUser_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.CreteUser_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.CreteUser_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedUserName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Content = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedUserName = c.String(maxLength: 30),
                        Blog_Id = c.Int(),
                        CreatedUser_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id)
                .ForeignKey("dbo.Users", t => t.CreatedUser_Id)
                .Index(t => t.Blog_Id)
                .Index(t => t.CreatedUser_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        UserType = c.Int(nullable: false),
                        ActiveCode = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedUserName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LikedBlogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Blog_Id = c.Int(),
                        LikedUser_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id)
                .ForeignKey("dbo.Users", t => t.LikedUser_Id)
                .Index(t => t.Blog_Id)
                .Index(t => t.LikedUser_Id);
            
            CreateTable(
                "dbo.LikedComments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Comment_Id = c.Long(),
                        LikedUser_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.Comment_Id)
                .ForeignKey("dbo.Users", t => t.LikedUser_Id)
                .Index(t => t.Comment_Id)
                .Index(t => t.LikedUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LikedComments", "LikedUser_Id", "dbo.Users");
            DropForeignKey("dbo.LikedComments", "Comment_Id", "dbo.Comments");
            DropForeignKey("dbo.LikedBlogs", "LikedUser_Id", "dbo.Users");
            DropForeignKey("dbo.LikedBlogs", "Blog_Id", "dbo.Blogs");
            DropForeignKey("dbo.Comments", "CreatedUser_Id", "dbo.Users");
            DropForeignKey("dbo.Blogs", "CreteUser_Id", "dbo.Users");
            DropForeignKey("dbo.Comments", "Blog_Id", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "Category_Id", "dbo.Categories");
            DropIndex("dbo.LikedComments", new[] { "LikedUser_Id" });
            DropIndex("dbo.LikedComments", new[] { "Comment_Id" });
            DropIndex("dbo.LikedBlogs", new[] { "LikedUser_Id" });
            DropIndex("dbo.LikedBlogs", new[] { "Blog_Id" });
            DropIndex("dbo.Comments", new[] { "CreatedUser_Id" });
            DropIndex("dbo.Comments", new[] { "Blog_Id" });
            DropIndex("dbo.Blogs", new[] { "CreteUser_Id" });
            DropIndex("dbo.Blogs", new[] { "Category_Id" });
            DropTable("dbo.LikedComments");
            DropTable("dbo.LikedBlogs");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
            DropTable("dbo.Blogs");
        }
    }
}
