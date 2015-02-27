// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace Microsoft.Data.Entity.Relational.Migrations.Infrastructure
{
    public interface IModelDiffer
    {
        bool HasDifferences([CanBeNull] IModel source, [CanBeNull] IModel target);

        IReadOnlyList<MigrationOperation> GetDifferences([CanBeNull] IModel source, [CanBeNull] IModel target);
    }
}
