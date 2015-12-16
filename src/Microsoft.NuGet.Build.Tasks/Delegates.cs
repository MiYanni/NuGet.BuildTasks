﻿// Copyright (c) .NET Foundation. All rights reserved. 
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

namespace Microsoft.NuGet.Build.Tasks
{
    internal delegate bool DirectoryExists(string path);
    internal delegate bool FileExists(string path);
    internal delegate string TryGetRuntimeVersion(string path);
}