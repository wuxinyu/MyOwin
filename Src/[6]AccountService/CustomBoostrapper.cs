﻿
namespace AccountService
{
    using Nancy;
    using Nancy.Conventions;

    public class CustomBoostrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);
            conventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("fonts", @"fonts"));
        }
    }
}