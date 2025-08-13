// Copyright © 2025 Eggnine Syndicate Ltd.
// All rights reserved.
// This file is part of the Sentient Horizon project.


namespace Eggnine.SentientHorizon.Testing.SkipAttributes
{
    public abstract class SkipIf : Attribute
    {
        /// <summary>
        /// Returns true if the test should be skipped
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public abstract bool Matches(TestContext ctx);
        
        /// <summary>
        /// Provides a reason that the test was skipped
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public abstract string Reason(TestContext ctx);

        public void True(TestContext ctx)
        {
            if(Matches(ctx))
            {
                string reason = Reason(ctx);
                Console.WriteLine($"skipping test {ctx.ClassName}.{ctx.TestName} because {reason}");
                throw new SkipException(reason);
            }
        }
    }
}
