// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis
{
    internal class ContainingMemberInfo
    {
        public string memberInfo;

        public static readonly ContainingMemberInfo None = new ContainingMemberInfo();

        public ContainingMemberInfo()
        {
        }
        public ContainingMemberInfo(string memberInfo)
        {
            this.memberInfo = memberInfo;
        }
    }
}
