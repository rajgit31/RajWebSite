<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<RajSoftware.Models.LinkItem>>" %>
<div class="blockheader">
    <b class="b1f"></b><b class="b2f"></b><b class="b3f"></b><b class="b4f"></b>
    <div id="divAspNetLinksHeader" class="rounded">
        <div>Links to favourite Blogs</div>
    </div>
    <b class="b4f"></b><b class="b3f"></b><b class="b2f"></b><b class="b1f"></b>
</div>
<div>
     <ul>
        <% foreach (RajSoftware.Models.LinkItem p in (IEnumerable<RajSoftware.Models.LinkItem>)Model)
           { %>
        <li><a href="<%= Html.Encode(p.Link) %>">
            <%= Html.Encode(p.Title) %> </a></li>
        <% } %>
     </ul>
</div>
