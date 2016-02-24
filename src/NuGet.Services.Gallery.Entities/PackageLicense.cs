﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NuGet.Services.Gallery
{
    public class PackageLicense
        : IEntity
    {
        public int Key { get; set; }

        [Required]
        [StringLength(PackageRegistration.MaxPackageIdLength)]
        public string Name { get; set; }

        public virtual ICollection<PackageLicenseReport> Reports { get; set; }
    }
}