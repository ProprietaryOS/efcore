﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.Query;

public class ManyToManyHeterogeneousQuerySqliteTest : ManyToManyHeterogeneousQueryRelationalTestBase
{
    protected override ITestStoreFactory TestStoreFactory
        => SqliteTestStoreFactory.Instance;
}
