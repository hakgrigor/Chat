using Chat.Migrations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace Chat.Models
{
    public class ApplicationDbInitializer : MigrateDatabaseToLatestVersion<ApplicationDbContext,Configuration>
    {
    }
}