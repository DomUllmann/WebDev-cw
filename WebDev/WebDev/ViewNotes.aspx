<%@ Page Title="Notes page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewNotes.aspx.cs" Inherits="WebDev.ViewNotes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper style1 first">
  <article class="container" id="top">
    <div class="row">
      <div class="col-lg-2"> </div>
      <div class="col-lg-8">
        <header>
            <asp:FormView ID="notes" runat="server" DataKeyNames="NotesID"
                        ItemType ="WebDev.Models.Notes" SelectMethod ="GetNotes">
                        <EmptyDataTemplate>
                            <h1><strong>Ooops! Somethings gone wrong!</strong></h1>
                            <h3>It looks like you didn't select a valid notes document. If you followed a link here,
                                try heading back and trying it again. If you came directly here, make sure
                                you supplied a notes ID</h3>
                            </h3>
                        </EmptyDataTemplate>

                        <ItemTemplate>
                            <header>
                                <h1><strong><%#: Item.NotesTitle %></strong></h1>
                                <h4>Asked by: <%#:Item.User %></h4>
                                <h4>Modified by: <%#:Item.UserModified %></h4>

                            </header>
                            <h5><%#:Item.NotesBody %></h5>
                        </ItemTemplate>
                    </asp:FormView>
        </header>
      </div>
    </div>
  </article>
</div>

    
</asp:Content>
