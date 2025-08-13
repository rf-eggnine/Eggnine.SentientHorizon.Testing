// Copyright © 2025 Eggnine Syndicate Ltd.
// All rights reserved.
// This file is part of the Sentient Horizon project.


namespace Eggnine.SentientHorizon.Testing.SkipAttributes
{
    public class SkipIfBrowserIsNot : SkipIf
    {
        public SkipIfBrowserIsNot(string browser)
        {
            Browser = browser;
        }

        public string Browser { get; }

        public override bool Matches(TestContext ctx)
        {
            return !string.Equals(Browser, ctx.BrowserName);
        }

        public override string Reason(TestContext ctx)
        {
            return $"BrowserName is {ctx.BrowserName} and not {Browser}";
        }
    }
}
