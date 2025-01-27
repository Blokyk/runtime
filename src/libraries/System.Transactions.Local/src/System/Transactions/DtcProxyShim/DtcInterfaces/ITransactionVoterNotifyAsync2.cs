﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Transactions.Oletx;

namespace System.Transactions.DtcProxyShim.DtcInterfaces;

// https://docs.microsoft.com/previous-versions/windows/desktop/ms678930(v=vs.85)
[ComImport, Guid("5433376B-414D-11d3-B206-00C04FC2F3EF"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITransactionVoterNotifyAsync2
{
    void Committed([MarshalAs(UnmanagedType.Bool)] bool fRetaining, IntPtr pNewUOW /* always null? */, uint hresult);

    void Aborted(IntPtr pboidReason, [MarshalAs(UnmanagedType.Bool)] bool fRetaining, IntPtr pNewUOW, uint hresult);

    void HeuristicDecision([MarshalAs(UnmanagedType.U4)] OletxTransactionHeuristic dwDecision, IntPtr pboidReason, uint hresult);

    void Indoubt();

    void VoteRequest();
}
