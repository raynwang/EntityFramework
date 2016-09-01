// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     TODO: ComplexType docs
    /// </summary>
    public interface IAccessibleProperty : IAnnotatable
    {
        /// <summary>
        ///     Gets the name of the property.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     TODO: ComplexType docs
        /// </summary>
        IStructuralType DeclaringType { get; }

        /// <summary>
        ///     Gets the type of value that this property holds.
        /// </summary>
        Type ClrType { get; }

        /// <summary>
        ///     TODO: ComplexType docs
        /// </summary>
        PropertyInfo PropertyInfo { get; }

        /// <summary>
        ///     TODO: ComplexType docs
        /// </summary>
        FieldInfo FieldInfo { get; }
    }
}