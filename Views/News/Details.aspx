<%@ Page Title="News" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 700px">
        <ul class="news">
            <% Html.RenderAction("News");  %>
        </ul>
    </div>
    <div style="width: 250px; height: 549px; float: right; margin-top: -550px;">
        <object data="data:application/x-silverlight," type="application/x-silverlight-2"
            width="100%" height="100%">
            <param name="source" value="http://msdnwidget.com.hosting0.smoothfusion.com/ClientBin/MSTechNetWizard.xap" />
            <param name="onError" value="onSilverlightError" />
            <param name="background" value="white" />
            <param name="minRuntimeVersion" value="3.0.40624.0" />
            <param name="autoUpgrade" value="true" />
            <param name="enablehtmlaccess" value="true" />
            <param name="initParams" value="WidgetID=371,state=1,Width=250,Height=549" />
            <a href="http://go.microsoft.com/fwlink/?LinkID=149156&v=3.0.40624.0" style="text-decoration: none">
                <img src="http://go.microsoft.com/fwlink/?LinkId=108181" alt="Get Microsoft Silverlight"
                    style="border-style: none" /></a></object>
    </div>
</asp:Content>
