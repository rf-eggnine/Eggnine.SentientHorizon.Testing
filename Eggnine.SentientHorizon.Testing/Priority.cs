// Copyright © 2025 Eggnine Syndicate Ltd.
// All rights reserved.
// This file is part of the Sentient Horizon project.


namespace Eggnine.SentientHorizon.Testing;

[AttributeUsage(AttributeTargets.Method)]
public class Priority : Attribute
{
    public Priority(int priority)
    {
    }
}
