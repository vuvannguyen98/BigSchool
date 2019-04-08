namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopluateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (1,'Development')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (2,'Business')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (3,'Marketing')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (4,'Accounting')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (5,'Food Technology')");
        }
        
        public override void Down()
        {
        }
    }
}
