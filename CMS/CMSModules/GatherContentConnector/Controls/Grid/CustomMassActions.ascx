﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomMassActions.ascx.cs" Inherits="GatherContentConnector.CMSModules.GatherContentConnector.Controls.Grid.CustomMassActions" %>

<div class="form-horizontal mass-action">
    <div class="form-group hidden" runat="server" id="divMessages">
    </div>
    <div class="form-group dont-check-changes">
        <div class="mass-action-value-cell">
            <cms:LocalizedLabel runat="server" AssociatedControlID="drpAction" CssClass="sr-only" ResourceString="general.scope" EnableViewState="False" />
            <cms:CMSDropDownList ID="drpScope" runat="server" />
            <cms:LocalizedLabel runat="server" AssociatedControlID="drpScope" CssClass="sr-only" ResourceString="general.action" EnableViewState="False" />
            <cms:CMSDropDownList ID="drpAction" runat="server" EnableViewState="False" />
            <cms:LocalizedButton runat="server" ID="btnOk" ButtonStyle="Primary" ResourceString="general.ok" EnableViewState="False" />
        </div>
    </div>
</div>