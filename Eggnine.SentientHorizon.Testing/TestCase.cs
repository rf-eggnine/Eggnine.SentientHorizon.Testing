// Copyright © 2025 Eggnine Syndicate Ltd.
// All rights reserved.
// This file is part of the Sentient Horizon project.


namespace Eggnine.SentientHorizon.Testing;
public class TestCase : Attribute
{
    private int _id;
    public TestCase(int id)
    {
        _id = id;
    }
}

