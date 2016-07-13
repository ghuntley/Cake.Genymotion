﻿using Cake.Genymotion.Admin;

namespace Cake.Genymotion.Tests.Fixtures.Admin
{
    internal sealed class GenymotionAdminStartFixture : GenymotionFixture<GenymotionAdminSettings>
    {
        protected override void RunTool()
        {
            var adminRunner = new GenymotionAdminRunner(FileSystem, Environment, ProcessRunner, Tools);
            adminRunner.Start("WIP");
        }
    }
}