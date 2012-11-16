<%@ Page Title="Home" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">    
    <div class="homepageleftcontent">        
        <% Html.RenderAction("CSharp");  %>
        <br />
        <% Html.RenderAction("UnitTests");  %>
        <br />
        <% Html.RenderAction("AspNet");  %>
        <br />
        <% Html.RenderAction("VisualStudio");  %>
        <br />
       <%-- <% Html.RenderAction("PnP");  %>
        <br />--%>
        <% Html.RenderAction("BookReviews");  %>
        <br />
        <% Html.RenderAction("BlogsList");  %>
        <br />
    </div>
    <br />
    <div>
        <div id="divsidebar" class="rightsidebar">
            <div class="clear"> 
            </div>
            <b class="b1fs"></b><b class="b2fs"></b><b class="b3fs"></b><b class="b4fs"></b>
            <div id="div1" class="roundeds">                
                <div id="divEvents" class="events">
                    <b>Events</b>
                    <ul>
                        <li><a href="http://dddsydney.com/" target="_blank">Developer Developer Developer!
                            Sydney - 2011</a></li>
                        <li><a href="http://www.dddmelbourne.com/" target="_blank">Developer Developer Developer!
                            Melbourne - 2011</a></li>
                        <li><a href="http://www.mvcconf.com/" target="_blank">Virtual MVC Conference</a></li>
                        <li><a href="http://codecampoz.com/" target="_blank">Code Camp Oz 2010</a></li>
                        <li><a href="http://www.dddsydney.com/" target="_blank">Developer Developer Developer!
                            Sydney - 2010</a></li>
                        <li><a href="http://www.microsoft.com/australia/remix/default.aspx" target="_blank">
                            REMiX 2010 - Melbourne</a></li>
                        <li><a href="http://www.dddmelbourne.com/" target="_blank">Developer Developer Developer!
                            Melbourne - 2010</a></li>
                        <li>Tech Ed 2008 Australia - Sydney </li>
                        <li>Code Camp 2005 Australia - Wagga Wagga NSW </li>
                    </ul>
                </div>              
                <br />
                <div id="div2" class="groups">
                    <b>Melbourne Developer User Groups</b>
                    <ul>
                        <li><a href="http://www.victoriadotnet.com.au" target="_blank">Victoria .NET</a></li>
                        <li><a href="http://melbournepatterns.org/" target="_blank">Melbourne Patterns Group</a></li>
                        <li><a href="http://melbourne.ozalt.net/" target="_blank">Melbourne ALT.NET Group</a></li>
                        <li><a href="http://www.deveve.net/" target="_blank">Melbourne Dev Eveninings</a></li>
                    </ul>
                </div>
                <div id="divUserGroups">
                    <a href="http://www.victoriadotnet.com.au/vic_index.aspx" target="_blank">
                        <img src="Images\vicdotnet.jpg" alt="Victoria .NET User Group" height="60px" width="140px"
                            class="usergroups" /></a>
                </div>
                <div>
                    <a href="/News/Details">
                        <img src="Images\msdn_news.jpg" alt="MSDN News & Events" style="width: 200px" /></a></div>
            </div>
            <b class="b4fs"></b><b class="b3fs"></b><b class="b2fs"></b><b class="b1fs"></b>
        </div>
    </div>
</asp:Content>
