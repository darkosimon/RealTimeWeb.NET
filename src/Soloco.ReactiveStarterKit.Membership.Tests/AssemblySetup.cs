﻿using NUnit.Framework;
using Soloco.ReactiveStarterKit.Common;
using Soloco.ReactiveStarterKit.Common.Tests;
using Soloco.ReactiveStarterKit.Membership.Client;

namespace Soloco.ReactiveStarterKit.Membership.Tests
{
    [SetUpFixture]
    public class IntegrationTestSetup
    {
        [SetUp]
        public void Setup()
        {
            TestContainer.Initialize(container => container
                .RegisterCommon()
                .RegisterMembership()
                .RegisterMembershipClient());
        }

        [TearDown]
        public void TearDown()
        {
            TestContainer.Dispose();
        }
    }
}