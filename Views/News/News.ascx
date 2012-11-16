<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<RajSoftware.Models.LinkItem>>" %>
<h1>
    <%= Resources.NewHeader%></h1>

<div>
    <ul>
        <% foreach (RajSoftware.Models.LinkItem p in (IEnumerable<RajSoftware.Models.LinkItem>)Model)
           { %>
        <li><a href="<%= Html.Encode(p.Link) %>">
            <%= p.Title %>
        </a>
            <%= Html.Encode(p.Description) %>
            <%= Html.Encode(p.Date) %>
        </li>
        <% } %>
    </ul>
</div>
