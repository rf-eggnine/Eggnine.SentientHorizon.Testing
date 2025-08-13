// Copyright © 2025 Eggnine Syndicate Ltd.
// All rights reserved.
// This file is part of the Sentient Horizon project.


namespace Eggnine.SentientHorizon.Testing.SkipAttributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class SkipIfOsIsNot : SkipIf
    {
        public SkipIfOsIsNot(string operatingSystem)
        {
            OperatingSystem = operatingSystem;
        }

        public string OperatingSystem { get; }

        public override bool Matches(TestContext ctx)
        {
            return !string.Equals(OperatingSystem, ctx.OperatingSystemName, StringComparison.OrdinalIgnoreCase);
        }

        public override string Reason(TestContext ctx)
        {
            return $"OperatingSystemName is {ctx.OperatingSystemName} and not {OperatingSystem}";
        }
    }
}
