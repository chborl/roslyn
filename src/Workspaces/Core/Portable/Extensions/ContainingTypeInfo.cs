// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis
{
    internal class ContainingTypeInfo
    {
        public string typeInfo;

        public static readonly ContainingTypeInfo None = new ContainingTypeInfo();

        public ContainingTypeInfo()
        {
        }
        public ContainingTypeInfo(string typeInfo)
        {
            this.typeInfo = typeInfo;
        }
    }
}
